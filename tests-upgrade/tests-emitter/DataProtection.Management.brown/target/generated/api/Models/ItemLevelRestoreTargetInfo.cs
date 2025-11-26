// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Restore target info for Item level restore operation</summary>
    public partial class ItemLevelRestoreTargetInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IItemLevelRestoreTargetInfo,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IItemLevelRestoreTargetInfoInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBase __restoreTargetInfoBase = new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.RestoreTargetInfoBase();

        /// <summary>Backing field for <see cref="DatasourceAuthCredentials" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials _datasourceAuthCredentials;

        /// <summary>Credentials to use to authenticate with data source provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials DatasourceAuthCredentials { get => (this._datasourceAuthCredentials = this._datasourceAuthCredentials ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AuthCredentials()); set => this._datasourceAuthCredentials = value; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceAuthCredentialsObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentialsInternal)DatasourceAuthCredentials).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentialsInternal)DatasourceAuthCredentials).ObjectType = value ?? null; }

        /// <summary>Backing field for <see cref="DatasourceInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource _datasourceInfo;

        /// <summary>Information of target DS</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource DatasourceInfo { get => (this._datasourceInfo = this._datasourceInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Datasource()); set => this._datasourceInfo = value; }

        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceInfoDatasourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).Type = value ?? null; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceInfoObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ObjectType = value ?? null; }

        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceInfoResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourceId = value ; }

        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceInfoResourceLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourceLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourceLocation = value ?? null; }

        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceInfoResourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourceName = value ?? null; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourcePropertyObjectType; }

        /// <summary>Properties specific to data source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties DatasourceInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourceProperty = value ?? null /* model class */; }

        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceInfoResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourceType = value ?? null; }

        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceInfoResourceUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourceUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourceUri = value ?? null; }

        /// <summary>Backing field for <see cref="DatasourceSetInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet _datasourceSetInfo;

        /// <summary>Information of target DS Set</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet DatasourceSetInfo { get => (this._datasourceSetInfo = this._datasourceSetInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceSet()); set => this._datasourceSetInfo = value; }

        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceSetInfoDatasourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).DatasourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).DatasourceType = value ?? null; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceSetInfoObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ObjectType = value ?? null; }

        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceSetInfoResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourceId = value ?? null; }

        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceSetInfoResourceLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourceLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourceLocation = value ?? null; }

        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceSetInfoResourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourceName = value ?? null; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceSetInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourcePropertyObjectType; }

        /// <summary>Properties specific to data source set</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties DatasourceSetInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourceProperty = value ?? null /* model class */; }

        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceSetInfoResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourceType = value ?? null; }

        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string DatasourceSetInfoResourceUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourceUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourceUri = value ?? null; }

        /// <summary>Internal Acessors for DatasourceAuthCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IItemLevelRestoreTargetInfoInternal.DatasourceAuthCredentials { get => (this._datasourceAuthCredentials = this._datasourceAuthCredentials ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.AuthCredentials()); set { {_datasourceAuthCredentials = value;} } }

        /// <summary>Internal Acessors for DatasourceInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IItemLevelRestoreTargetInfoInternal.DatasourceInfo { get => (this._datasourceInfo = this._datasourceInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Datasource()); set { {_datasourceInfo = value;} } }

        /// <summary>Internal Acessors for DatasourceInfoResourcePropertiesObjectType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IItemLevelRestoreTargetInfoInternal.DatasourceInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourcePropertyObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourcePropertyObjectType = value ?? null; }

        /// <summary>Internal Acessors for DatasourceInfoResourceProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IItemLevelRestoreTargetInfoInternal.DatasourceInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceInternal)DatasourceInfo).ResourceProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DatasourceSetInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IItemLevelRestoreTargetInfoInternal.DatasourceSetInfo { get => (this._datasourceSetInfo = this._datasourceSetInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.DatasourceSet()); set { {_datasourceSetInfo = value;} } }

        /// <summary>Internal Acessors for DatasourceSetInfoResourcePropertiesObjectType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IItemLevelRestoreTargetInfoInternal.DatasourceSetInfoResourcePropertiesObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourcePropertyObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourcePropertyObjectType = value ?? null; }

        /// <summary>Internal Acessors for DatasourceSetInfoResourceProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IItemLevelRestoreTargetInfoInternal.DatasourceSetInfoResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSetInternal)DatasourceSetInfo).ResourceProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for RecoveryOption</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal.RecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RecoveryOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RecoveryOption = value ; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string ObjectType { get => "ItemLevelRestoreTargetInfo"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).ObjectType = "ItemLevelRestoreTargetInfo"; }

        /// <summary>Recovery Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string RecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RecoveryOption; }

        /// <summary>Backing field for <see cref="RestoreCriterion" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IItemLevelRestoreCriteria> _restoreCriterion;

        /// <summary>Restore Criteria</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IItemLevelRestoreCriteria> RestoreCriterion { get => this._restoreCriterion; set => this._restoreCriterion = value; }

        /// <summary>Target Restore region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string RestoreLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RestoreLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RestoreLocation = value ?? null; }

        /// <summary>Creates an new <see cref="ItemLevelRestoreTargetInfo" /> instance.</summary>
        public ItemLevelRestoreTargetInfo()
        {
            this.__restoreTargetInfoBase.ObjectType = "ItemLevelRestoreTargetInfo";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__restoreTargetInfoBase), __restoreTargetInfoBase);
            await eventListener.AssertObjectIsValid(nameof(__restoreTargetInfoBase), __restoreTargetInfoBase);
        }
    }
    /// Restore target info for Item level restore operation
    public partial interface IItemLevelRestoreTargetInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBase
    {
        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the specific object - used for deserializing",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceAuthCredentialsObjectType { get; set; }
        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"DatasourceType of the resource.",
        SerializedName = @"datasourceType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceInfoDatasourceType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of Datasource object, used to initialize the right inherited type",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceInfoObjectType { get; set; }
        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created by backup service via Fabric/Vault.",
        SerializedName = @"resourceID",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceInfoResourceId { get; set; }
        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Location of datasource.",
        SerializedName = @"resourceLocation",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceInfoResourceLocation { get; set; }
        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Unique identifier of the resource in the context of parent.",
        SerializedName = @"resourceName",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceInfoResourceName { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the specific object - used for deserializing",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceInfoResourcePropertiesObjectType { get;  }
        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Type of Datasource.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceInfoResourceType { get; set; }
        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Uri of the resource.",
        SerializedName = @"resourceUri",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceInfoResourceUri { get; set; }
        /// <summary>DatasourceType of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"DatasourceType of the resource.",
        SerializedName = @"datasourceType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceSetInfoDatasourceType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of Datasource object, used to initialize the right inherited type",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceSetInfoObjectType { get; set; }
        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created by backup service via Fabric/Vault.",
        SerializedName = @"resourceID",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceSetInfoResourceId { get; set; }
        /// <summary>Location of datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Location of datasource.",
        SerializedName = @"resourceLocation",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceSetInfoResourceLocation { get; set; }
        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Unique identifier of the resource in the context of parent.",
        SerializedName = @"resourceName",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceSetInfoResourceName { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the specific object - used for deserializing",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceSetInfoResourcePropertiesObjectType { get;  }
        /// <summary>Resource Type of Datasource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Type of Datasource.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceSetInfoResourceType { get; set; }
        /// <summary>Uri of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Uri of the resource.",
        SerializedName = @"resourceUri",
        PossibleTypes = new [] { typeof(string) })]
        string DatasourceSetInfoResourceUri { get; set; }
        /// <summary>Restore Criteria</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Restore Criteria",
        SerializedName = @"restoreCriteria",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IItemLevelRestoreCriteria) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IItemLevelRestoreCriteria> RestoreCriterion { get; set; }

    }
    /// Restore target info for Item level restore operation
    internal partial interface IItemLevelRestoreTargetInfoInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IRestoreTargetInfoBaseInternal
    {
        /// <summary>Credentials to use to authenticate with data source provider.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IAuthCredentials DatasourceAuthCredentials { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        string DatasourceAuthCredentialsObjectType { get; set; }
        /// <summary>Information of target DS</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasource DatasourceInfo { get; set; }
        /// <summary>DatasourceType of the resource.</summary>
        string DatasourceInfoDatasourceType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        string DatasourceInfoObjectType { get; set; }
        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        string DatasourceInfoResourceId { get; set; }
        /// <summary>Location of datasource.</summary>
        string DatasourceInfoResourceLocation { get; set; }
        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        string DatasourceInfoResourceName { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        string DatasourceInfoResourcePropertiesObjectType { get; set; }
        /// <summary>Properties specific to data source</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties DatasourceInfoResourceProperty { get; set; }
        /// <summary>Resource Type of Datasource.</summary>
        string DatasourceInfoResourceType { get; set; }
        /// <summary>Uri of the resource.</summary>
        string DatasourceInfoResourceUri { get; set; }
        /// <summary>Information of target DS Set</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IDatasourceSet DatasourceSetInfo { get; set; }
        /// <summary>DatasourceType of the resource.</summary>
        string DatasourceSetInfoDatasourceType { get; set; }
        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        string DatasourceSetInfoObjectType { get; set; }
        /// <summary>
        /// Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created
        /// by backup service via Fabric/Vault.
        /// </summary>
        string DatasourceSetInfoResourceId { get; set; }
        /// <summary>Location of datasource.</summary>
        string DatasourceSetInfoResourceLocation { get; set; }
        /// <summary>Unique identifier of the resource in the context of parent.</summary>
        string DatasourceSetInfoResourceName { get; set; }
        /// <summary>Type of the specific object - used for deserializing</summary>
        string DatasourceSetInfoResourcePropertiesObjectType { get; set; }
        /// <summary>Properties specific to data source set</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IBaseResourceProperties DatasourceSetInfoResourceProperty { get; set; }
        /// <summary>Resource Type of Datasource.</summary>
        string DatasourceSetInfoResourceType { get; set; }
        /// <summary>Uri of the resource.</summary>
        string DatasourceSetInfoResourceUri { get; set; }
        /// <summary>Restore Criteria</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IItemLevelRestoreCriteria> RestoreCriterion { get; set; }

    }
}