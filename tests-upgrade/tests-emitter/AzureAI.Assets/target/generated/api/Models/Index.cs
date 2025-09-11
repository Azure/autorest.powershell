// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Index resource Definition</summary>
    public partial class Index :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndex,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description information of the asset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>
        /// Fully qualified resource Id: azureml://workspace/{workspaceName}/indexes/{name}/versions/{version} of the index.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal)SystemData).CreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexProperties _property;

        /// <summary>
        /// Asset's properties. Unlike tags, properties are add-only. Once added, a property cannot be removed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IndexProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="Stage" /> property.</summary>
        private string _stage;

        /// <summary>
        /// Update stage to 'Archive' to archive the asset. Default is Development, which means the asset is under development.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Stage { get => this._stage; set => this._stage = value; }

        /// <summary>Backing field for <see cref="StorageUri" /> property.</summary>
        private string _storageUri;

        /// <summary>
        /// Default workspace blob storage Uri. Should work across storage types and auth scenarios.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string StorageUri { get => this._storageUri; set => this._storageUri = value; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemData _systemData;

        /// <summary>Metadata containing createdBy and modifiedBy information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.SystemData()); }

        /// <summary>The timestamp the resource was created at.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal)SystemData).CreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal)SystemData).CreatedBy; }

        /// <summary>The identity type that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal)SystemData).CreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal)SystemData).LastModifiedAt; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexTags _tag;

        /// <summary>Asset's tags. Unlike properties, tags are fully mutable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IndexTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="Index" /> instance.</summary>
        public Index()
        {

        }
    }
    /// Index resource Definition
    public partial interface IIndex :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Description information of the asset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Description information of the asset.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>
        /// Fully qualified resource Id: azureml://workspace/{workspaceName}/indexes/{name}/versions/{version} of the index.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Fully qualified resource Id: azureml://workspace/{workspaceName}/indexes/{name}/versions/{version} of the index.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>
        /// Asset's properties. Unlike tags, properties are add-only. Once added, a property cannot be removed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Asset's properties. Unlike tags, properties are add-only. Once added, a property cannot be removed.",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexProperties Property { get; set; }
        /// <summary>
        /// Update stage to 'Archive' to archive the asset. Default is Development, which means the asset is under development.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Update stage to 'Archive' to archive the asset. Default is Development, which means the asset is under development.",
        SerializedName = @"stage",
        PossibleTypes = new [] { typeof(string) })]
        string Stage { get; set; }
        /// <summary>
        /// Default workspace blob storage Uri. Should work across storage types and auth scenarios.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Default workspace blob storage Uri. Should work across storage types and auth scenarios.",
        SerializedName = @"storageUri",
        PossibleTypes = new [] { typeof(string) })]
        string StorageUri { get; set; }
        /// <summary>The timestamp the resource was created at.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp the resource was created at.",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get;  }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get;  }
        /// <summary>The identity type that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identity type that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedByType { get;  }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get;  }
        /// <summary>Asset's tags. Unlike properties, tags are fully mutable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Asset's tags. Unlike properties, tags are fully mutable.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexTags Tag { get; set; }

    }
    /// Index resource Definition
    internal partial interface IIndexInternal

    {
        /// <summary>Description information of the asset.</summary>
        string Description { get; set; }
        /// <summary>
        /// Fully qualified resource Id: azureml://workspace/{workspaceName}/indexes/{name}/versions/{version} of the index.
        /// </summary>
        string Id { get; set; }
        /// <summary>
        /// Asset's properties. Unlike tags, properties are add-only. Once added, a property cannot be removed.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexProperties Property { get; set; }
        /// <summary>
        /// Update stage to 'Archive' to archive the asset. Default is Development, which means the asset is under development.
        /// </summary>
        string Stage { get; set; }
        /// <summary>
        /// Default workspace blob storage Uri. Should work across storage types and auth scenarios.
        /// </summary>
        string StorageUri { get; set; }
        /// <summary>Metadata containing createdBy and modifiedBy information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemData SystemData { get; set; }
        /// <summary>The timestamp the resource was created at.</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The identity type that created the resource.</summary>
        string SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>Asset's tags. Unlike properties, tags are fully mutable.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IIndexTags Tag { get; set; }

    }
}