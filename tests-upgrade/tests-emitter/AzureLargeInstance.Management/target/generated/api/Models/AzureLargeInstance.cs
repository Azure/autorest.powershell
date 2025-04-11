// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>
    /// Azure Large Instance info on Azure (ARM properties and AzureLargeInstance
    /// properties)
    /// </summary>
    public partial class AzureLargeInstance :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstance,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.TrackedResource();

        /// <summary>Specifies the Azure Large Instance unique ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string AzureLargeInstanceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).AzureLargeInstanceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).AzureLargeInstanceId = value ?? null; }

        /// <summary>Specifies the Azure Large Instance SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string HardwareProfileAzureLargeInstanceSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).HardwareProfileAzureLargeInstanceSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).HardwareProfileAzureLargeInstanceSize = value ?? null; }

        /// <summary>Name of the hardware type (vendor and/or their product name)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string HardwareProfileHardwareType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).HardwareProfileHardwareType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).HardwareProfileHardwareType = value ?? null; }

        /// <summary>Hardware revision of an Azure Large Instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string HwRevision { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).HwRevision; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).HwRevision = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Internal Acessors for HardwareProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IHardwareProfile Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceInternal.HardwareProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).HardwareProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).HardwareProfile = value; }

        /// <summary>Internal Acessors for NetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.INetworkProfile Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceInternal.NetworkProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).NetworkProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).NetworkProfile = value; }

        /// <summary>Internal Acessors for OSProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfile Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceInternal.OSProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).OSProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).OSProfile = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceProperties Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeInstanceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for StorageProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProfile Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceInternal.StorageProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).StorageProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).StorageProfile = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value; }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Specifies the circuit id for connecting to express route.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string NetworkProfileCircuitId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).NetworkProfileCircuitId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).NetworkProfileCircuitId = value ?? null; }

        /// <summary>Specifies the network interfaces for the Azure Large Instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress> NetworkProfileNetworkInterface { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).NetworkProfileNetworkInterface; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).NetworkProfileNetworkInterface = value ?? null /* arrayOf */; }

        /// <summary>Specifies the host OS name of the Azure Large Instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string OSProfileComputerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).OSProfileComputerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).OSProfileComputerName = value ?? null; }

        /// <summary>This property allows you to specify the type of the OS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string OSProfileOstype { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).OSProfileOstype; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).OSProfileOstype = value ?? null; }

        /// <summary>Specifies the SSH public key used to access the operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string OSProfileSshPublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).OSProfileSshPublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).OSProfileSshPublicKey = value ?? null; }

        /// <summary>Specifies version of operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string OSProfileVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).OSProfileVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).OSProfileVersion = value ?? null; }

        /// <summary>Resource power state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string PowerState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).PowerState; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).PowerState = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeInstanceProperties()); set => this._property = value; }

        /// <summary>State of provisioning of the AzureLargeInstance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Resource proximity placement group</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string ProximityPlacementGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).ProximityPlacementGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).ProximityPlacementGroup = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>IP Address to connect to storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StorageProfileNfsIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).StorageProfileNfsIPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).StorageProfileNfsIPAddress = value ?? null; }

        /// <summary>
        /// Specifies information about the operating system disk used by Azure Large
        /// Instance.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk> StorageProfileOSDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).StorageProfileOSDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal)Property).StorageProfileOSDisk = value ?? null /* arrayOf */; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="AzureLargeInstance" /> instance.</summary>
        public AzureLargeInstance()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Azure Large Instance info on Azure (ARM properties and AzureLargeInstance
    /// properties)
    public partial interface IAzureLargeInstance :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResource
    {
        /// <summary>Specifies the Azure Large Instance unique ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the Azure Large Instance unique ID.",
        SerializedName = @"azureLargeInstanceId",
        PossibleTypes = new [] { typeof(string) })]
        string AzureLargeInstanceId { get; set; }
        /// <summary>Specifies the Azure Large Instance SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the Azure Large Instance SKU.",
        SerializedName = @"azureLargeInstanceSize",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("S72m", "S144m", "S72", "S144", "S192", "S192m", "S192xm", "S96", "S112", "S224", "S224m", "S224om", "S224oo", "S224oom", "S224ooo", "S224se", "S384", "S384m", "S384xm", "S384xxm", "S448", "S448m", "S448om", "S448oo", "S448oom", "S448ooo", "S448se", "S576m", "S576xm", "S672", "S672m", "S672om", "S672oo", "S672oom", "S672ooo", "S768", "S768m", "S768xm", "S896", "S896m", "S896om", "S896oo", "S896oom", "S896ooo", "S960m")]
        string HardwareProfileAzureLargeInstanceSize { get; set; }
        /// <summary>Name of the hardware type (vendor and/or their product name)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the hardware type (vendor and/or their product name)",
        SerializedName = @"hardwareType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Cisco_UCS", "HPE", "SDFLEX")]
        string HardwareProfileHardwareType { get; set; }
        /// <summary>Hardware revision of an Azure Large Instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Hardware revision of an Azure Large Instance",
        SerializedName = @"hwRevision",
        PossibleTypes = new [] { typeof(string) })]
        string HwRevision { get; set; }
        /// <summary>Specifies the circuit id for connecting to express route.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the circuit id for connecting to express route.",
        SerializedName = @"circuitId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkProfileCircuitId { get; set; }
        /// <summary>Specifies the network interfaces for the Azure Large Instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the network interfaces for the Azure Large Instance.",
        SerializedName = @"networkInterfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress> NetworkProfileNetworkInterface { get; set; }
        /// <summary>Specifies the host OS name of the Azure Large Instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the host OS name of the Azure Large Instance.",
        SerializedName = @"computerName",
        PossibleTypes = new [] { typeof(string) })]
        string OSProfileComputerName { get; set; }
        /// <summary>This property allows you to specify the type of the OS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This property allows you to specify the type of the OS.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        string OSProfileOstype { get; set; }
        /// <summary>Specifies the SSH public key used to access the operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the SSH public key used to access the operating system.",
        SerializedName = @"sshPublicKey",
        PossibleTypes = new [] { typeof(string) })]
        string OSProfileSshPublicKey { get; set; }
        /// <summary>Specifies version of operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies version of operating system.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string OSProfileVersion { get; set; }
        /// <summary>Resource power state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource power state",
        SerializedName = @"powerState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("starting", "started", "stopping", "stopped", "restarting", "unknown")]
        string PowerState { get; set; }
        /// <summary>State of provisioning of the AzureLargeInstance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"State of provisioning of the AzureLargeInstance",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Failed", "Succeeded", "Deleting", "Migrating", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>Resource proximity placement group</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource proximity placement group",
        SerializedName = @"proximityPlacementGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ProximityPlacementGroup { get; set; }
        /// <summary>IP Address to connect to storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IP Address to connect to storage.",
        SerializedName = @"nfsIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string StorageProfileNfsIPAddress { get; set; }
        /// <summary>
        /// Specifies information about the operating system disk used by Azure Large
        /// Instance.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies information about the operating system disk used by Azure Large
        Instance.",
        SerializedName = @"osDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk> StorageProfileOSDisk { get; set; }

    }
    /// Azure Large Instance info on Azure (ARM properties and AzureLargeInstance
    /// properties)
    internal partial interface IAzureLargeInstanceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITrackedResourceInternal
    {
        /// <summary>Specifies the Azure Large Instance unique ID.</summary>
        string AzureLargeInstanceId { get; set; }
        /// <summary>Specifies the hardware settings for the Azure Large Instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IHardwareProfile HardwareProfile { get; set; }
        /// <summary>Specifies the Azure Large Instance SKU.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("S72m", "S144m", "S72", "S144", "S192", "S192m", "S192xm", "S96", "S112", "S224", "S224m", "S224om", "S224oo", "S224oom", "S224ooo", "S224se", "S384", "S384m", "S384xm", "S384xxm", "S448", "S448m", "S448om", "S448oo", "S448oom", "S448ooo", "S448se", "S576m", "S576xm", "S672", "S672m", "S672om", "S672oo", "S672oom", "S672ooo", "S768", "S768m", "S768xm", "S896", "S896m", "S896om", "S896oo", "S896oom", "S896ooo", "S960m")]
        string HardwareProfileAzureLargeInstanceSize { get; set; }
        /// <summary>Name of the hardware type (vendor and/or their product name)</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Cisco_UCS", "HPE", "SDFLEX")]
        string HardwareProfileHardwareType { get; set; }
        /// <summary>Hardware revision of an Azure Large Instance</summary>
        string HwRevision { get; set; }
        /// <summary>Specifies the network settings for the Azure Large Instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.INetworkProfile NetworkProfile { get; set; }
        /// <summary>Specifies the circuit id for connecting to express route.</summary>
        string NetworkProfileCircuitId { get; set; }
        /// <summary>Specifies the network interfaces for the Azure Large Instance.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress> NetworkProfileNetworkInterface { get; set; }
        /// <summary>Specifies the operating system settings for the Azure Large Instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfile OSProfile { get; set; }
        /// <summary>Specifies the host OS name of the Azure Large Instance.</summary>
        string OSProfileComputerName { get; set; }
        /// <summary>This property allows you to specify the type of the OS.</summary>
        string OSProfileOstype { get; set; }
        /// <summary>Specifies the SSH public key used to access the operating system.</summary>
        string OSProfileSshPublicKey { get; set; }
        /// <summary>Specifies version of operating system.</summary>
        string OSProfileVersion { get; set; }
        /// <summary>Resource power state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("starting", "started", "stopping", "stopped", "restarting", "unknown")]
        string PowerState { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceProperties Property { get; set; }
        /// <summary>State of provisioning of the AzureLargeInstance</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Failed", "Succeeded", "Deleting", "Migrating", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Resource proximity placement group</summary>
        string ProximityPlacementGroup { get; set; }
        /// <summary>Specifies the storage settings for the Azure Large Instance disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProfile StorageProfile { get; set; }
        /// <summary>IP Address to connect to storage.</summary>
        string StorageProfileNfsIPAddress { get; set; }
        /// <summary>
        /// Specifies information about the operating system disk used by Azure Large
        /// Instance.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk> StorageProfileOSDisk { get; set; }

    }
}