// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.PowerShell;

    /// <summary>The Fleet resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(FleetTypeConverter))]
    public partial class Fleet
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.Fleet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleet" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleet DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Fleet(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.Fleet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleet" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleet DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Fleet(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.Fleet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Fleet(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile) content.GetValueForProperty("HubProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetHubProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfileAgentProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileAgentProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfile) content.GetValueForProperty("HubProfileAgentProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileAgentProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AgentProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ManagedServiceIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("HubProfileApiServerAccessProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileApiServerAccessProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfile) content.GetValueForProperty("HubProfileApiServerAccessProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileApiServerAccessProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ApiServerAccessProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("HubProfileDnsPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileDnsPrefix = (string) content.GetValueForProperty("HubProfileDnsPrefix",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileDnsPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfileFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileFqdn = (string) content.GetValueForProperty("HubProfileFqdn",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfileKubernetesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileKubernetesVersion = (string) content.GetValueForProperty("HubProfileKubernetesVersion",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileKubernetesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfilePortalFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfilePortalFqdn = (string) content.GetValueForProperty("HubProfilePortalFqdn",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfilePortalFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("ApiServerAccessProfileSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ApiServerAccessProfileSubnetId = (string) content.GetValueForProperty("ApiServerAccessProfileSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ApiServerAccessProfileSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("AgentProfileSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).AgentProfileSubnetId = (string) content.GetValueForProperty("AgentProfileSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).AgentProfileSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("StatusLastOperationError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).StatusLastOperationError = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail) content.GetValueForProperty("StatusLastOperationError",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).StatusLastOperationError, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("StatusLastOperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).StatusLastOperationId = (string) content.GetValueForProperty("StatusLastOperationId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).StatusLastOperationId, global::System.Convert.ToString);
            }
            if (content.Contains("ApiServerAccessProfileEnablePrivateCluster"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ApiServerAccessProfileEnablePrivateCluster = (bool?) content.GetValueForProperty("ApiServerAccessProfileEnablePrivateCluster",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ApiServerAccessProfileEnablePrivateCluster, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApiServerAccessProfileEnableVnetIntegration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ApiServerAccessProfileEnableVnetIntegration = (bool?) content.GetValueForProperty("ApiServerAccessProfileEnableVnetIntegration",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ApiServerAccessProfileEnableVnetIntegration, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AgentProfileVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).AgentProfileVMSize = (string) content.GetValueForProperty("AgentProfileVMSize",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).AgentProfileVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorCode = (string) content.GetValueForProperty("LastOperationErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorMessage = (string) content.GetValueForProperty("LastOperationErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorMessage, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorTarget = (string) content.GetValueForProperty("LastOperationErrorTarget",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorTarget, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>) content.GetValueForProperty("LastOperationErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("LastOperationErrorAdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorAdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>) content.GetValueForProperty("LastOperationErrorAdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorAdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.Fleet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Fleet(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile) content.GetValueForProperty("HubProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetHubProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfileAgentProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileAgentProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfile) content.GetValueForProperty("HubProfileAgentProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileAgentProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AgentProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ManagedServiceIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("HubProfileApiServerAccessProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileApiServerAccessProfile = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfile) content.GetValueForProperty("HubProfileApiServerAccessProfile",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileApiServerAccessProfile, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ApiServerAccessProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("HubProfileDnsPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileDnsPrefix = (string) content.GetValueForProperty("HubProfileDnsPrefix",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileDnsPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfileFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileFqdn = (string) content.GetValueForProperty("HubProfileFqdn",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfileKubernetesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileKubernetesVersion = (string) content.GetValueForProperty("HubProfileKubernetesVersion",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfileKubernetesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("HubProfilePortalFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfilePortalFqdn = (string) content.GetValueForProperty("HubProfilePortalFqdn",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).HubProfilePortalFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("ApiServerAccessProfileSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ApiServerAccessProfileSubnetId = (string) content.GetValueForProperty("ApiServerAccessProfileSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ApiServerAccessProfileSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("AgentProfileSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).AgentProfileSubnetId = (string) content.GetValueForProperty("AgentProfileSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).AgentProfileSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("StatusLastOperationError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).StatusLastOperationError = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail) content.GetValueForProperty("StatusLastOperationError",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).StatusLastOperationError, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("StatusLastOperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).StatusLastOperationId = (string) content.GetValueForProperty("StatusLastOperationId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).StatusLastOperationId, global::System.Convert.ToString);
            }
            if (content.Contains("ApiServerAccessProfileEnablePrivateCluster"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ApiServerAccessProfileEnablePrivateCluster = (bool?) content.GetValueForProperty("ApiServerAccessProfileEnablePrivateCluster",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ApiServerAccessProfileEnablePrivateCluster, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApiServerAccessProfileEnableVnetIntegration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ApiServerAccessProfileEnableVnetIntegration = (bool?) content.GetValueForProperty("ApiServerAccessProfileEnableVnetIntegration",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).ApiServerAccessProfileEnableVnetIntegration, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AgentProfileVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).AgentProfileVMSize = (string) content.GetValueForProperty("AgentProfileVMSize",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).AgentProfileVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorCode = (string) content.GetValueForProperty("LastOperationErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorMessage = (string) content.GetValueForProperty("LastOperationErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorMessage, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorTarget = (string) content.GetValueForProperty("LastOperationErrorTarget",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorTarget, global::System.Convert.ToString);
            }
            if (content.Contains("LastOperationErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>) content.GetValueForProperty("LastOperationErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("LastOperationErrorAdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorAdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>) content.GetValueForProperty("LastOperationErrorAdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal)this).LastOperationErrorAdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Fleet" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Fleet" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleet FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The Fleet resource.
    [System.ComponentModel.TypeConverter(typeof(FleetTypeConverter))]
    public partial interface IFleet

    {

    }
}