// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>An image version object</summary>
    public partial class ImageVersion :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersion,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ProxyResource();

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionProperties Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ImageVersionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ImageVersionProperties()); set => this._property = value; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Version of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionPropertiesInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionPropertiesInternal)Property).Version = value ?? null; }

        /// <summary>Creates an new <see cref="ImageVersion" /> instance.</summary>
        public ImageVersion()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// An image version object
    public partial interface IImageVersion :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IProxyResource
    {
        /// <summary>Version of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Version of the image.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// An image version object
    internal partial interface IImageVersionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IProxyResourceInternal
    {
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionProperties Property { get; set; }
        /// <summary>Version of the image.</summary>
        string Version { get; set; }

    }
}