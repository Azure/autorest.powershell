// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Defines the asset status event properties.</summary>
    public partial class AssetStatusEvent :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEvent,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEventInternal
    {

        /// <summary>Backing field for <see cref="MessageSchemaReference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReference _messageSchemaReference;

        /// <summary>The message schema reference object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReference MessageSchemaReference { get => (this._messageSchemaReference = this._messageSchemaReference ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.MessageSchemaReference()); }

        /// <summary>The message schema name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string MessageSchemaReferenceSchemaName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReferenceInternal)MessageSchemaReference).SchemaName; }

        /// <summary>The message schema registry namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string MessageSchemaReferenceSchemaRegistryNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReferenceInternal)MessageSchemaReference).SchemaRegistryNamespace; }

        /// <summary>The message schema version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string MessageSchemaReferenceSchemaVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReferenceInternal)MessageSchemaReference).SchemaVersion; }

        /// <summary>Internal Acessors for MessageSchemaReference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReference Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEventInternal.MessageSchemaReference { get => (this._messageSchemaReference = this._messageSchemaReference ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.MessageSchemaReference()); set { {_messageSchemaReference = value;} } }

        /// <summary>Internal Acessors for MessageSchemaReferenceSchemaName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEventInternal.MessageSchemaReferenceSchemaName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReferenceInternal)MessageSchemaReference).SchemaName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReferenceInternal)MessageSchemaReference).SchemaName = value ?? null; }

        /// <summary>Internal Acessors for MessageSchemaReferenceSchemaRegistryNamespace</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEventInternal.MessageSchemaReferenceSchemaRegistryNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReferenceInternal)MessageSchemaReference).SchemaRegistryNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReferenceInternal)MessageSchemaReference).SchemaRegistryNamespace = value ?? null; }

        /// <summary>Internal Acessors for MessageSchemaReferenceSchemaVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEventInternal.MessageSchemaReferenceSchemaVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReferenceInternal)MessageSchemaReference).SchemaVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReferenceInternal)MessageSchemaReference).SchemaVersion = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusEventInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// The name of the event. Must be unique within the status.events array. This name is used to correlate between the spec
        /// and status event information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Creates an new <see cref="AssetStatusEvent" /> instance.</summary>
        public AssetStatusEvent()
        {

        }
    }
    /// Defines the asset status event properties.
    public partial interface IAssetStatusEvent :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable
    {
        /// <summary>The message schema name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The message schema name.",
        SerializedName = @"schemaName",
        PossibleTypes = new [] { typeof(string) })]
        string MessageSchemaReferenceSchemaName { get;  }
        /// <summary>The message schema registry namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The message schema registry namespace.",
        SerializedName = @"schemaRegistryNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string MessageSchemaReferenceSchemaRegistryNamespace { get;  }
        /// <summary>The message schema version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The message schema version.",
        SerializedName = @"schemaVersion",
        PossibleTypes = new [] { typeof(string) })]
        string MessageSchemaReferenceSchemaVersion { get;  }
        /// <summary>
        /// The name of the event. Must be unique within the status.events array. This name is used to correlate between the spec
        /// and status event information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the event. Must be unique within the status.events array. This name is used to correlate between the spec and status event information.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }

    }
    /// Defines the asset status event properties.
    internal partial interface IAssetStatusEventInternal

    {
        /// <summary>The message schema reference object.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReference MessageSchemaReference { get; set; }
        /// <summary>The message schema name.</summary>
        string MessageSchemaReferenceSchemaName { get; set; }
        /// <summary>The message schema registry namespace.</summary>
        string MessageSchemaReferenceSchemaRegistryNamespace { get; set; }
        /// <summary>The message schema version.</summary>
        string MessageSchemaReferenceSchemaVersion { get; set; }
        /// <summary>
        /// The name of the event. Must be unique within the status.events array. This name is used to correlate between the spec
        /// and status event information.
        /// </summary>
        string Name { get; set; }

    }
}