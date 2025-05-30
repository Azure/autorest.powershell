// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Defines the message schema reference properties.</summary>
    public partial class MessageSchemaReference :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReference,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReferenceInternal
    {

        /// <summary>Internal Acessors for SchemaName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReferenceInternal.SchemaName { get => this._schemaName; set { {_schemaName = value;} } }

        /// <summary>Internal Acessors for SchemaRegistryNamespace</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReferenceInternal.SchemaRegistryNamespace { get => this._schemaRegistryNamespace; set { {_schemaRegistryNamespace = value;} } }

        /// <summary>Internal Acessors for SchemaVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IMessageSchemaReferenceInternal.SchemaVersion { get => this._schemaVersion; set { {_schemaVersion = value;} } }

        /// <summary>Backing field for <see cref="SchemaName" /> property.</summary>
        private string _schemaName;

        /// <summary>The message schema name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string SchemaName { get => this._schemaName; }

        /// <summary>Backing field for <see cref="SchemaRegistryNamespace" /> property.</summary>
        private string _schemaRegistryNamespace;

        /// <summary>The message schema registry namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string SchemaRegistryNamespace { get => this._schemaRegistryNamespace; }

        /// <summary>Backing field for <see cref="SchemaVersion" /> property.</summary>
        private string _schemaVersion;

        /// <summary>The message schema version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string SchemaVersion { get => this._schemaVersion; }

        /// <summary>Creates an new <see cref="MessageSchemaReference" /> instance.</summary>
        public MessageSchemaReference()
        {

        }
    }
    /// Defines the message schema reference properties.
    public partial interface IMessageSchemaReference :
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
        string SchemaName { get;  }
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
        string SchemaRegistryNamespace { get;  }
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
        string SchemaVersion { get;  }

    }
    /// Defines the message schema reference properties.
    internal partial interface IMessageSchemaReferenceInternal

    {
        /// <summary>The message schema name.</summary>
        string SchemaName { get; set; }
        /// <summary>The message schema registry namespace.</summary>
        string SchemaRegistryNamespace { get; set; }
        /// <summary>The message schema version.</summary>
        string SchemaVersion { get; set; }

    }
}