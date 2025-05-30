// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Extensions;

    /// <summary>
    /// Resource that represents an Azure Extended Zone available to a subscription for registering and unregistering.
    /// </summary>
    public partial class ExtendedZone :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZone,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneInternal,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.ProxyResource();

        /// <summary>Display name of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).DisplayName; }

        /// <summary>Geography of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inlined)]
        public string Geography { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).Geography; }

        /// <summary>The Geography Group of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inlined)]
        public string GeographyGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).GeographyGroup; }

        /// <summary>The Home Location of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inlined)]
        public string HomeLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).HomeLocation; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>The Latitude of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inlined)]
        public string Latitude { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).Latitude; }

        /// <summary>The Longitude of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inlined)]
        public string Longitude { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).Longitude; }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneInternal.DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).DisplayName = value ?? null; }

        /// <summary>Internal Acessors for Geography</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneInternal.Geography { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).Geography; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).Geography = value ?? null; }

        /// <summary>Internal Acessors for GeographyGroup</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneInternal.GeographyGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).GeographyGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).GeographyGroup = value ?? null; }

        /// <summary>Internal Acessors for HomeLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneInternal.HomeLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).HomeLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).HomeLocation = value ?? null; }

        /// <summary>Internal Acessors for Latitude</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneInternal.Latitude { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).Latitude; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).Latitude = value ?? null; }

        /// <summary>Internal Acessors for Longitude</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneInternal.Longitude { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).Longitude; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).Longitude = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneProperties Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.ExtendedZoneProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for RegionCategory</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneInternal.RegionCategory { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).RegionCategory; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).RegionCategory = value ?? null; }

        /// <summary>Internal Acessors for RegionType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneInternal.RegionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).RegionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).RegionType = value ?? null; }

        /// <summary>Internal Acessors for RegionalDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneInternal.RegionalDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).RegionalDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).RegionalDisplayName = value ?? null; }

        /// <summary>Internal Acessors for RegistrationState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneInternal.RegistrationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).RegistrationState; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).RegistrationState = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.ExtendedZoneProperties()); set => this._property = value; }

        /// <summary>
        /// Status of the last operation performed by the subscription on the Edge Zone resource
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Category of region for the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inlined)]
        public string RegionCategory { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).RegionCategory; }

        /// <summary>Type of region for the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inlined)]
        public string RegionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).RegionType; }

        /// <summary>Regional display name of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inlined)]
        public string RegionalDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).RegionalDisplayName; }

        /// <summary>Indicates the Azure Extended Zone registration’s approval status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inlined)]
        public string RegistrationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal)Property).RegistrationState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="ExtendedZone" /> instance.</summary>
        public ExtendedZone()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Resource that represents an Azure Extended Zone available to a subscription for registering and unregistering.
    public partial interface IExtendedZone :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IProxyResource
    {
        /// <summary>Display name of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Display name of the Azure Extended Zone.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get;  }
        /// <summary>Geography of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Geography of the Azure Extended Zone.",
        SerializedName = @"geography",
        PossibleTypes = new [] { typeof(string) })]
        string Geography { get;  }
        /// <summary>The Geography Group of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Geography Group of the Azure Extended Zone.",
        SerializedName = @"geographyGroup",
        PossibleTypes = new [] { typeof(string) })]
        string GeographyGroup { get;  }
        /// <summary>The Home Location of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Home Location of the Azure Extended Zone.",
        SerializedName = @"homeLocation",
        PossibleTypes = new [] { typeof(string) })]
        string HomeLocation { get;  }
        /// <summary>The Latitude of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Latitude of the Azure Extended Zone.",
        SerializedName = @"latitude",
        PossibleTypes = new [] { typeof(string) })]
        string Latitude { get;  }
        /// <summary>The Longitude of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Longitude of the Azure Extended Zone.",
        SerializedName = @"longitude",
        PossibleTypes = new [] { typeof(string) })]
        string Longitude { get;  }
        /// <summary>
        /// Status of the last operation performed by the subscription on the Edge Zone resource
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of the last operation performed by the subscription on the Edge Zone resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>Category of region for the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Category of region for the Azure Extended Zone.",
        SerializedName = @"regionCategory",
        PossibleTypes = new [] { typeof(string) })]
        string RegionCategory { get;  }
        /// <summary>Type of region for the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Type of region for the Azure Extended Zone.",
        SerializedName = @"regionType",
        PossibleTypes = new [] { typeof(string) })]
        string RegionType { get;  }
        /// <summary>Regional display name of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Regional display name of the Azure Extended Zone.",
        SerializedName = @"regionalDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string RegionalDisplayName { get;  }
        /// <summary>Indicates the Azure Extended Zone registration’s approval status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Indicates the Azure Extended Zone registration’s approval status.",
        SerializedName = @"registrationState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PSArgumentCompleterAttribute("NotRegistered", "PendingRegister", "Registered", "PendingUnregister")]
        string RegistrationState { get;  }

    }
    /// Resource that represents an Azure Extended Zone available to a subscription for registering and unregistering.
    internal partial interface IExtendedZoneInternal :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IProxyResourceInternal
    {
        /// <summary>Display name of the Azure Extended Zone.</summary>
        string DisplayName { get; set; }
        /// <summary>Geography of the Azure Extended Zone.</summary>
        string Geography { get; set; }
        /// <summary>The Geography Group of the Azure Extended Zone.</summary>
        string GeographyGroup { get; set; }
        /// <summary>The Home Location of the Azure Extended Zone.</summary>
        string HomeLocation { get; set; }
        /// <summary>The Latitude of the Azure Extended Zone.</summary>
        string Latitude { get; set; }
        /// <summary>The Longitude of the Azure Extended Zone.</summary>
        string Longitude { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneProperties Property { get; set; }
        /// <summary>
        /// Status of the last operation performed by the subscription on the Edge Zone resource
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Category of region for the Azure Extended Zone.</summary>
        string RegionCategory { get; set; }
        /// <summary>Type of region for the Azure Extended Zone.</summary>
        string RegionType { get; set; }
        /// <summary>Regional display name of the Azure Extended Zone.</summary>
        string RegionalDisplayName { get; set; }
        /// <summary>Indicates the Azure Extended Zone registration’s approval status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PSArgumentCompleterAttribute("NotRegistered", "PendingRegister", "Registered", "PendingUnregister")]
        string RegistrationState { get; set; }

    }
}