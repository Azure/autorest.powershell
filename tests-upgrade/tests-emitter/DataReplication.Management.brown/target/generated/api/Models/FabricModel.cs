// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Fabric model.</summary>
    public partial class FabricModel :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModel,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.TrackedResource();

        /// <summary>Fabric model custom properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomProperties CustomProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).CustomProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).CustomProperty = value ?? null /* model class */; }

        /// <summary>Discriminator property for FabricModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CustomPropertyInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).CustomPropertyInstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).CustomPropertyInstanceType = value ?? null; }

        /// <summary>Gets or sets the fabric health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string Health { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).Health; }

        /// <summary>Gets or sets the list of health errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> HealthError { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).HealthError; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Internal Acessors for CustomProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelInternal.CustomProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).CustomProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).CustomProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Health</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelInternal.Health { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).Health; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).Health = value ?? null; }

        /// <summary>Internal Acessors for HealthError</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelInternal.HealthError { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).HealthError; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).HealthError = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.FabricModelProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for ServiceEndpoint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelInternal.ServiceEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).ServiceEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).ServiceEndpoint = value ?? null; }

        /// <summary>Internal Acessors for ServiceResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelInternal.ServiceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).ServiceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).ServiceResourceId = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.FabricModelProperties()); set => this._property = value; }

        /// <summary>Gets or sets the provisioning state of the fabric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Gets or sets the service endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ServiceEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).ServiceEndpoint; }

        /// <summary>Gets or sets the service resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ServiceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelPropertiesInternal)Property).ServiceResourceId; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="FabricModel" /> instance.</summary>
        public FabricModel()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Fabric model.
    public partial interface IFabricModel :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITrackedResource
    {
        /// <summary>Discriminator property for FabricModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Discriminator property for FabricModelCustomProperties.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string CustomPropertyInstanceType { get; set; }
        /// <summary>Gets or sets the fabric health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the fabric health.",
        SerializedName = @"health",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Normal", "Warning", "Critical")]
        string Health { get;  }
        /// <summary>Gets or sets the list of health errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the list of health errors.",
        SerializedName = @"healthErrors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> HealthError { get;  }
        /// <summary>Gets or sets the provisioning state of the fabric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the provisioning state of the fabric.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get;  }
        /// <summary>Gets or sets the service endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the service endpoint.",
        SerializedName = @"serviceEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceEndpoint { get;  }
        /// <summary>Gets or sets the service resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the service resource Id.",
        SerializedName = @"serviceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceResourceId { get;  }

    }
    /// Fabric model.
    internal partial interface IFabricModelInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITrackedResourceInternal
    {
        /// <summary>Fabric model custom properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomProperties CustomProperty { get; set; }
        /// <summary>Discriminator property for FabricModelCustomProperties.</summary>
        string CustomPropertyInstanceType { get; set; }
        /// <summary>Gets or sets the fabric health.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Normal", "Warning", "Critical")]
        string Health { get; set; }
        /// <summary>Gets or sets the list of health errors.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> HealthError { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelProperties Property { get; set; }
        /// <summary>Gets or sets the provisioning state of the fabric.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get; set; }
        /// <summary>Gets or sets the service endpoint.</summary>
        string ServiceEndpoint { get; set; }
        /// <summary>Gets or sets the service resource Id.</summary>
        string ServiceResourceId { get; set; }

    }
}