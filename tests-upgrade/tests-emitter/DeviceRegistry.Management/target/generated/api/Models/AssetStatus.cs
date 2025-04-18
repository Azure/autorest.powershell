// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Defines the asset status properties.</summary>
    public partial class AssetStatus :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatus,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal
    {

        /// <summary>Backing field for <see cref="Dataset" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset> _dataset;

        /// <summary>Array of dataset statuses that describe the status of each dataset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset> Dataset { get => this._dataset; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError> _error;

        /// <summary>Array object to transfer and persist errors that originate from the Edge.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError> Error { get => this._error; }

        /// <summary>Backing field for <see cref="Event" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent> _event;

        /// <summary>Array of event statuses that describe the status of each event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent> Event { get => this._event; }

        /// <summary>Internal Acessors for Dataset</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset> Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal.Dataset { get => this._dataset; set { {_dataset = value;} } }

        /// <summary>Internal Acessors for Error</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError> Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal.Error { get => this._error; set { {_error = value;} } }

        /// <summary>Internal Acessors for Event</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent> Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal.Event { get => this._event; set { {_event = value;} } }

        /// <summary>Internal Acessors for Version</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusInternal.Version { get => this._version; set { {_version = value;} } }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private long? _version;

        /// <summary>
        /// A read only incremental counter indicating the number of times the configuration has been modified from the perspective
        /// of the current actual (Edge) state of the Asset. Edge would be the only writer of this value and would sync back up to
        /// the cloud. In steady state, this should equal version.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public long? Version { get => this._version; }

        /// <summary>Creates an new <see cref="AssetStatus" /> instance.</summary>
        public AssetStatus()
        {

        }
    }
    /// Defines the asset status properties.
    public partial interface IAssetStatus :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable
    {
        /// <summary>Array of dataset statuses that describe the status of each dataset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Array of dataset statuses that describe the status of each dataset.",
        SerializedName = @"datasets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset> Dataset { get;  }
        /// <summary>Array object to transfer and persist errors that originate from the Edge.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Array object to transfer and persist errors that originate from the Edge.",
        SerializedName = @"errors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError> Error { get;  }
        /// <summary>Array of event statuses that describe the status of each event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Array of event statuses that describe the status of each event.",
        SerializedName = @"events",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent> Event { get;  }
        /// <summary>
        /// A read only incremental counter indicating the number of times the configuration has been modified from the perspective
        /// of the current actual (Edge) state of the Asset. Edge would be the only writer of this value and would sync back up to
        /// the cloud. In steady state, this should equal version.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A read only incremental counter indicating the number of times the configuration has been modified from the perspective of the current actual (Edge) state of the Asset. Edge would be the only writer of this value and would sync back up to the cloud. In steady state, this should equal version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(long) })]
        long? Version { get;  }

    }
    /// Defines the asset status properties.
    internal partial interface IAssetStatusInternal

    {
        /// <summary>Array of dataset statuses that describe the status of each dataset.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusDataset> Dataset { get; set; }
        /// <summary>Array object to transfer and persist errors that originate from the Edge.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError> Error { get; set; }
        /// <summary>Array of event statuses that describe the status of each event.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent> Event { get; set; }
        /// <summary>
        /// A read only incremental counter indicating the number of times the configuration has been modified from the perspective
        /// of the current actual (Edge) state of the Asset. Edge would be the only writer of this value and would sync back up to
        /// the cloud. In steady state, this should equal version.
        /// </summary>
        long? Version { get; set; }

    }
}