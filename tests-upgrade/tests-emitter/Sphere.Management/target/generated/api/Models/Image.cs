// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>An image resource belonging to a catalog resource.</summary>
    public partial class Image :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImage,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ProxyResource();

        /// <summary>The image component id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string ComponentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).ComponentId; }

        /// <summary>The image description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).Description; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Image ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string ImageId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).ImageId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).ImageId = value ?? null; }

        /// <summary>Image name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string ImageName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).ImageName; }

        /// <summary>The image type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string ImageType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).ImageType; }

        /// <summary>Internal Acessors for ComponentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageInternal.ComponentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).ComponentId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).ComponentId = value ?? null; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageInternal.Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).Description = value ?? null; }

        /// <summary>Internal Acessors for ImageName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageInternal.ImageName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).ImageName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).ImageName = value ?? null; }

        /// <summary>Internal Acessors for ImageType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageInternal.ImageType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).ImageType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).ImageType = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageProperties Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ImageProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Uri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageInternal.Uri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).Uri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).Uri = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>
        /// Image as a UTF-8 encoded base 64 string on image create. This field contains the image URI on image reads.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string PropertiesImage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).Image; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).Image = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ImageProperties()); set => this._property = value; }

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Regional data boundary for an image</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string RegionalDataBoundary { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).RegionalDataBoundary; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).RegionalDataBoundary = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Location the image</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string Uri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImagePropertiesInternal)Property).Uri; }

        /// <summary>Creates an new <see cref="Image" /> instance.</summary>
        public Image()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader0) is string __headerRetryAfterHeader0 ? int.TryParse( __headerRetryAfterHeader0, out int __headerRetryAfterHeader0Value ) ? __headerRetryAfterHeader0Value : default(int?) : default(int?);
            }
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// An image resource belonging to a catalog resource.
    public partial interface IImage :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProxyResource
    {
        /// <summary>The image component id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The image component id.",
        SerializedName = @"componentId",
        PossibleTypes = new [] { typeof(string) })]
        string ComponentId { get;  }
        /// <summary>The image description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The image description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>Image ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Image ID",
        SerializedName = @"imageId",
        PossibleTypes = new [] { typeof(string) })]
        string ImageId { get; set; }
        /// <summary>Image name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Image name",
        SerializedName = @"imageName",
        PossibleTypes = new [] { typeof(string) })]
        string ImageName { get;  }
        /// <summary>The image type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The image type.",
        SerializedName = @"imageType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("InvalidImageType", "OneBl", "PlutonRuntime", "WifiFirmware", "SecurityMonitor", "NormalWorldLoader", "NormalWorldDtb", "NormalWorldKernel", "RootFs", "Services", "Applications", "FwConfig", "BootManifest", "Nwfs", "TrustedKeystore", "Policy", "CustomerBoardConfig", "UpdateCertStore", "BaseSystemUpdateManifest", "FirmwareUpdateManifest", "CustomerUpdateManifest", "RecoveryManifest", "ManifestSet", "Other")]
        string ImageType { get;  }
        /// <summary>
        /// Image as a UTF-8 encoded base 64 string on image create. This field contains the image URI on image reads.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Image as a UTF-8 encoded base 64 string on image create. This field contains the image URI on image reads.",
        SerializedName = @"image",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesImage { get; set; }
        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>Regional data boundary for an image</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Regional data boundary for an image",
        SerializedName = @"regionalDataBoundary",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("None", "EU")]
        string RegionalDataBoundary { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }
        /// <summary>Location the image</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Location the image",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get;  }

    }
    /// An image resource belonging to a catalog resource.
    internal partial interface IImageInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProxyResourceInternal
    {
        /// <summary>The image component id.</summary>
        string ComponentId { get; set; }
        /// <summary>The image description.</summary>
        string Description { get; set; }
        /// <summary>Image ID</summary>
        string ImageId { get; set; }
        /// <summary>Image name</summary>
        string ImageName { get; set; }
        /// <summary>The image type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("InvalidImageType", "OneBl", "PlutonRuntime", "WifiFirmware", "SecurityMonitor", "NormalWorldLoader", "NormalWorldDtb", "NormalWorldKernel", "RootFs", "Services", "Applications", "FwConfig", "BootManifest", "Nwfs", "TrustedKeystore", "Policy", "CustomerBoardConfig", "UpdateCertStore", "BaseSystemUpdateManifest", "FirmwareUpdateManifest", "CustomerUpdateManifest", "RecoveryManifest", "ManifestSet", "Other")]
        string ImageType { get; set; }
        /// <summary>
        /// Image as a UTF-8 encoded base 64 string on image create. This field contains the image URI on image reads.
        /// </summary>
        string PropertiesImage { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageProperties Property { get; set; }
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Regional data boundary for an image</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("None", "EU")]
        string RegionalDataBoundary { get; set; }

        int? RetryAfter { get; set; }
        /// <summary>Location the image</summary>
        string Uri { get; set; }

    }
}