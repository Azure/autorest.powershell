// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>A Serverless Runtime environment resource by Informatica.</summary>
    public partial class InformaticaServerlessRuntimeResource :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResource,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ProxyResource();

        /// <summary>String KV pairs indicating Advanced custom properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties> AdvancedCustomProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).AdvancedCustomProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).AdvancedCustomProperty = value ?? null /* arrayOf */; }

        /// <summary>Application type of the Serverless Runtime environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ApplicationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ApplicationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ApplicationType = value ?? null; }

        /// <summary>Compute units of the serverless runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ComputeUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ComputeUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ComputeUnit = value ?? null; }

        /// <summary>description of the serverless runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).Description = value ?? null; }

        /// <summary>Serverless Execution timeout</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ExecutionTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ExecutionTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ExecutionTimeout = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeProperties Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaServerlessRuntimeProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for ServerlessRuntimeConfig</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigProperties Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal.ServerlessRuntimeConfig { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeConfig; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeConfig = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ServerlessRuntimeNetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfile Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal.ServerlessRuntimeNetworkProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeNetworkProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeNetworkProfile = value ?? null /* model class */; }

        /// <summary>
        /// Internal Acessors for ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfiguration Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal.ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ServerlessRuntimeUserContextProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextProperties Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal.ServerlessRuntimeUserContextProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeUserContextProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeUserContextProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Virtual network subnet resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string NetworkInterfaceConfigurationSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).NetworkInterfaceConfigurationSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).NetworkInterfaceConfigurationSubnetId = value ?? null; }

        /// <summary>Virtual network resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string NetworkInterfaceConfigurationVnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).NetworkInterfaceConfigurationVnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).NetworkInterfaceConfigurationVnetId = value ?? null; }

        /// <summary>Virtual network resource guid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string NetworkInterfaceConfigurationVnetResourceGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).NetworkInterfaceConfigurationVnetResourceGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).NetworkInterfaceConfigurationVnetResourceGuid = value ?? null; }

        /// <summary>Platform type of the Serverless Runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string Platform { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).Platform; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).Platform = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InformaticaServerlessRuntimeProperties()); set => this._property = value; }

        /// <summary>Provisioning State of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>Serverless account creation location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessAccountLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessAccountLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessAccountLocation = value ?? null; }

        /// <summary>The List of Informatica Serverless Runtime CDI Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdiConfigProp { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeConfigCdiConfigProp; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeConfigCdiConfigProp = value ?? null /* arrayOf */; }

        /// <summary>The List of Informatica Serverless Runtime CDIE Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdieConfigProp { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeConfigCdieConfigProp; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeConfigCdieConfigProp = value ?? null /* arrayOf */; }

        /// <summary>Serverless Runtime Tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag> ServerlessRuntimeTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeTag = value ?? null /* arrayOf */; }

        /// <summary>User context token for OBO flow.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessRuntimeUserContextPropertyUserContextToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeUserContextPropertyUserContextToken; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).ServerlessRuntimeUserContextPropertyUserContextToken = value ?? null; }

        /// <summary>Supplementary file location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string SupplementaryFileLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).SupplementaryFileLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal)Property).SupplementaryFileLocation = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="InformaticaServerlessRuntimeResource" /> instance.</summary>
        public InformaticaServerlessRuntimeResource()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader0) is string __headerRetryAfterHeader0 ? int.TryParse( __headerRetryAfterHeader0, out int __headerRetryAfterHeader0Value ) ? __headerRetryAfterHeader0Value : default(int?) : default(int?);
            }
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// A Serverless Runtime environment resource by Informatica.
    public partial interface IInformaticaServerlessRuntimeResource :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IProxyResource
    {
        /// <summary>String KV pairs indicating Advanced custom properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"String KV pairs indicating Advanced custom properties.",
        SerializedName = @"advancedCustomProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties> AdvancedCustomProperty { get; set; }
        /// <summary>Application type of the Serverless Runtime environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Application type of the Serverless Runtime environment.",
        SerializedName = @"applicationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("CDI", "CDIE")]
        string ApplicationType { get; set; }
        /// <summary>Compute units of the serverless runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Compute units of the serverless runtime.",
        SerializedName = @"computeUnits",
        PossibleTypes = new [] { typeof(string) })]
        string ComputeUnit { get; set; }
        /// <summary>description of the serverless runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"description of the serverless runtime.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Serverless Execution timeout</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serverless Execution timeout",
        SerializedName = @"executionTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string ExecutionTimeout { get; set; }
        /// <summary>Virtual network subnet resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual network subnet resource id",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkInterfaceConfigurationSubnetId { get; set; }
        /// <summary>Virtual network resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual network resource id",
        SerializedName = @"vnetId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkInterfaceConfigurationVnetId { get; set; }
        /// <summary>Virtual network resource guid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual network resource guid",
        SerializedName = @"vnetResourceGuid",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkInterfaceConfigurationVnetResourceGuid { get; set; }
        /// <summary>Platform type of the Serverless Runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Platform type of the Serverless Runtime.",
        SerializedName = @"platform",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("AZURE")]
        string Platform { get; set; }
        /// <summary>Provisioning State of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning State of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted", "NotSpecified")]
        string ProvisioningState { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }
        /// <summary>Serverless account creation location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serverless account creation location",
        SerializedName = @"serverlessAccountLocation",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessAccountLocation { get; set; }
        /// <summary>The List of Informatica Serverless Runtime CDI Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The List of Informatica Serverless Runtime CDI Config Properties.",
        SerializedName = @"cdiConfigProps",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdiConfigProp { get; set; }
        /// <summary>The List of Informatica Serverless Runtime CDIE Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The List of Informatica Serverless Runtime CDIE Config Properties.",
        SerializedName = @"cdieConfigProps",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdieConfigProp { get; set; }
        /// <summary>Serverless Runtime Tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serverless Runtime Tags",
        SerializedName = @"serverlessRuntimeTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag> ServerlessRuntimeTag { get; set; }
        /// <summary>User context token for OBO flow.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User context token for OBO flow.",
        SerializedName = @"userContextToken",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessRuntimeUserContextPropertyUserContextToken { get; set; }
        /// <summary>Supplementary file location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Supplementary file location.",
        SerializedName = @"supplementaryFileLocation",
        PossibleTypes = new [] { typeof(string) })]
        string SupplementaryFileLocation { get; set; }

    }
    /// A Serverless Runtime environment resource by Informatica.
    internal partial interface IInformaticaServerlessRuntimeResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IProxyResourceInternal
    {
        /// <summary>String KV pairs indicating Advanced custom properties.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties> AdvancedCustomProperty { get; set; }
        /// <summary>Application type of the Serverless Runtime environment.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("CDI", "CDIE")]
        string ApplicationType { get; set; }
        /// <summary>Compute units of the serverless runtime.</summary>
        string ComputeUnit { get; set; }
        /// <summary>description of the serverless runtime.</summary>
        string Description { get; set; }
        /// <summary>Serverless Execution timeout</summary>
        string ExecutionTimeout { get; set; }
        /// <summary>Virtual network subnet resource id</summary>
        string NetworkInterfaceConfigurationSubnetId { get; set; }
        /// <summary>Virtual network resource id</summary>
        string NetworkInterfaceConfigurationVnetId { get; set; }
        /// <summary>Virtual network resource guid</summary>
        string NetworkInterfaceConfigurationVnetResourceGuid { get; set; }
        /// <summary>Platform type of the Serverless Runtime.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("AZURE")]
        string Platform { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeProperties Property { get; set; }
        /// <summary>Provisioning State of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted", "NotSpecified")]
        string ProvisioningState { get; set; }

        int? RetryAfter { get; set; }
        /// <summary>Serverless account creation location</summary>
        string ServerlessAccountLocation { get; set; }
        /// <summary>Serverless config properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigProperties ServerlessRuntimeConfig { get; set; }
        /// <summary>The List of Informatica Serverless Runtime CDI Config Properties.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdiConfigProp { get; set; }
        /// <summary>The List of Informatica Serverless Runtime CDIE Config Properties.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdieConfigProp { get; set; }
        /// <summary>Informatica Serverless Network profile properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfile ServerlessRuntimeNetworkProfile { get; set; }
        /// <summary>Network Interface Configuration Profile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfiguration ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration { get; set; }
        /// <summary>Serverless Runtime Tags</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag> ServerlessRuntimeTag { get; set; }
        /// <summary>Serverless runtime user context properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextProperties ServerlessRuntimeUserContextProperty { get; set; }
        /// <summary>User context token for OBO flow.</summary>
        string ServerlessRuntimeUserContextPropertyUserContextToken { get; set; }
        /// <summary>Supplementary file location.</summary>
        string SupplementaryFileLocation { get; set; }

    }
}