// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Dependency reference for a serverless runtime resource</summary>
    public partial class ServerlessRuntimeDependency :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeDependency,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeDependencyInternal
    {

        /// <summary>Backing field for <see cref="AppContextId" /> property.</summary>
        private string _appContextId;

        /// <summary>Application context ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string AppContextId { get => this._appContextId; set => this._appContextId = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>description of Dependency</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DocumentType" /> property.</summary>
        private string _documentType;

        /// <summary>document type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string DocumentType { get => this._documentType; set => this._documentType = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Dependency ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="LastUpdatedTime" /> property.</summary>
        private string _lastUpdatedTime;

        /// <summary>Last Update Time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string LastUpdatedTime { get => this._lastUpdatedTime; set => this._lastUpdatedTime = value; }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        /// <summary>Dependency path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Creates an new <see cref="ServerlessRuntimeDependency" /> instance.</summary>
        public ServerlessRuntimeDependency()
        {

        }
    }
    /// Dependency reference for a serverless runtime resource
    public partial interface IServerlessRuntimeDependency :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>Application context ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Application context ID",
        SerializedName = @"appContextId",
        PossibleTypes = new [] { typeof(string) })]
        string AppContextId { get; set; }
        /// <summary>description of Dependency</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"description of Dependency",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>document type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"document type",
        SerializedName = @"documentType",
        PossibleTypes = new [] { typeof(string) })]
        string DocumentType { get; set; }
        /// <summary>Dependency ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Dependency ID",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Last Update Time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Last Update Time",
        SerializedName = @"lastUpdatedTime",
        PossibleTypes = new [] { typeof(string) })]
        string LastUpdatedTime { get; set; }
        /// <summary>Dependency path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Dependency path",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get; set; }

    }
    /// Dependency reference for a serverless runtime resource
    internal partial interface IServerlessRuntimeDependencyInternal

    {
        /// <summary>Application context ID</summary>
        string AppContextId { get; set; }
        /// <summary>description of Dependency</summary>
        string Description { get; set; }
        /// <summary>document type</summary>
        string DocumentType { get; set; }
        /// <summary>Dependency ID</summary>
        string Id { get; set; }
        /// <summary>Last Update Time</summary>
        string LastUpdatedTime { get; set; }
        /// <summary>Dependency path</summary>
        string Path { get; set; }

    }
}