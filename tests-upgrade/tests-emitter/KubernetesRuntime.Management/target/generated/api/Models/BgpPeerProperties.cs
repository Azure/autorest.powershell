// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;

    /// <summary>Details of the BgpPeer.</summary>
    public partial class BgpPeerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IBgpPeerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IBgpPeerPropertiesInternal
    {

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IBgpPeerPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="MyAsn" /> property.</summary>
        private int _myAsn;

        /// <summary>My ASN</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public int MyAsn { get => this._myAsn; set => this._myAsn = value; }

        /// <summary>Backing field for <see cref="PeerAddress" /> property.</summary>
        private string _peerAddress;

        /// <summary>Peer Address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string PeerAddress { get => this._peerAddress; set => this._peerAddress = value; }

        /// <summary>Backing field for <see cref="PeerAsn" /> property.</summary>
        private int _peerAsn;

        /// <summary>Peer ASN</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public int PeerAsn { get => this._peerAsn; set => this._peerAsn = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Resource provision state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="BgpPeerProperties" /> instance.</summary>
        public BgpPeerProperties()
        {

        }
    }
    /// Details of the BgpPeer.
    public partial interface IBgpPeerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IJsonSerializable
    {
        /// <summary>My ASN</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"My ASN",
        SerializedName = @"myAsn",
        PossibleTypes = new [] { typeof(int) })]
        int MyAsn { get; set; }
        /// <summary>Peer Address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Peer Address",
        SerializedName = @"peerAddress",
        PossibleTypes = new [] { typeof(string) })]
        string PeerAddress { get; set; }
        /// <summary>Peer ASN</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Peer ASN",
        SerializedName = @"peerAsn",
        PossibleTypes = new [] { typeof(int) })]
        int PeerAsn { get; set; }
        /// <summary>Resource provision state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource provision state",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }

    }
    /// Details of the BgpPeer.
    internal partial interface IBgpPeerPropertiesInternal

    {
        /// <summary>My ASN</summary>
        int MyAsn { get; set; }
        /// <summary>Peer Address</summary>
        string PeerAddress { get; set; }
        /// <summary>Peer ASN</summary>
        int PeerAsn { get; set; }
        /// <summary>Resource provision state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }

    }
}