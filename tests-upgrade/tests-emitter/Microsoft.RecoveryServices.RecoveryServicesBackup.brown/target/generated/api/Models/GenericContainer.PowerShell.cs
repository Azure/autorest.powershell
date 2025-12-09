// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>Base class for generic container of backup items</summary>
    [System.ComponentModel.TypeConverter(typeof(GenericContainerTypeConverter))]
    public partial class GenericContainer
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.GenericContainer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainer" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainer DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new GenericContainer(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.GenericContainer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainer" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainer DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new GenericContainer(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="GenericContainer" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="GenericContainer" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainer FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.GenericContainer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal GenericContainer(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ExtendedInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformation = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerExtendedInfo) content.GetValueForProperty("ExtendedInformation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformation, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.GenericContainerExtendedInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("FabricName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).FabricName = (string) content.GetValueForProperty("FabricName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).FabricName, global::System.Convert.ToString);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("BackupManagementType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).BackupManagementType = (string) content.GetValueForProperty("BackupManagementType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).BackupManagementType, global::System.Convert.ToString);
            }
            if (content.Contains("RegistrationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).RegistrationStatus = (string) content.GetValueForProperty("RegistrationStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).RegistrationStatus, global::System.Convert.ToString);
            }
            if (content.Contains("HealthStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).HealthStatus = (string) content.GetValueForProperty("HealthStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).HealthStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ContainerType = (string) content.GetValueForProperty("ContainerType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ContainerType, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectableObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ProtectableObjectType = (string) content.GetValueForProperty("ProtectableObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ProtectableObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInformationContainerIdentityInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformationContainerIdentityInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IContainerIdentityInfo) content.GetValueForProperty("ExtendedInformationContainerIdentityInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformationContainerIdentityInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ContainerIdentityInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedInformationRawCertData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformationRawCertData = (string) content.GetValueForProperty("ExtendedInformationRawCertData",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformationRawCertData, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInformationServiceEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformationServiceEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerExtendedInfoServiceEndpoints) content.GetValueForProperty("ExtendedInformationServiceEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformationServiceEndpoint, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.GenericContainerExtendedInfoServiceEndpointsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ContainerIdentityInfoUniqueName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoUniqueName = (string) content.GetValueForProperty("ContainerIdentityInfoUniqueName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoUniqueName, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerIdentityInfoAadTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoAadTenantId = (string) content.GetValueForProperty("ContainerIdentityInfoAadTenantId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoAadTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerIdentityInfoServicePrincipalClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoServicePrincipalClientId = (string) content.GetValueForProperty("ContainerIdentityInfoServicePrincipalClientId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoServicePrincipalClientId, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerIdentityInfoAudience"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoAudience = (string) content.GetValueForProperty("ContainerIdentityInfoAudience",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoAudience, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.GenericContainer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal GenericContainer(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ExtendedInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformation = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerExtendedInfo) content.GetValueForProperty("ExtendedInformation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformation, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.GenericContainerExtendedInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("FabricName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).FabricName = (string) content.GetValueForProperty("FabricName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).FabricName, global::System.Convert.ToString);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("BackupManagementType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).BackupManagementType = (string) content.GetValueForProperty("BackupManagementType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).BackupManagementType, global::System.Convert.ToString);
            }
            if (content.Contains("RegistrationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).RegistrationStatus = (string) content.GetValueForProperty("RegistrationStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).RegistrationStatus, global::System.Convert.ToString);
            }
            if (content.Contains("HealthStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).HealthStatus = (string) content.GetValueForProperty("HealthStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).HealthStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ContainerType = (string) content.GetValueForProperty("ContainerType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ContainerType, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectableObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ProtectableObjectType = (string) content.GetValueForProperty("ProtectableObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ProtectableObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInformationContainerIdentityInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformationContainerIdentityInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IContainerIdentityInfo) content.GetValueForProperty("ExtendedInformationContainerIdentityInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformationContainerIdentityInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ContainerIdentityInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedInformationRawCertData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformationRawCertData = (string) content.GetValueForProperty("ExtendedInformationRawCertData",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformationRawCertData, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInformationServiceEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformationServiceEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerExtendedInfoServiceEndpoints) content.GetValueForProperty("ExtendedInformationServiceEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ExtendedInformationServiceEndpoint, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.GenericContainerExtendedInfoServiceEndpointsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ContainerIdentityInfoUniqueName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoUniqueName = (string) content.GetValueForProperty("ContainerIdentityInfoUniqueName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoUniqueName, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerIdentityInfoAadTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoAadTenantId = (string) content.GetValueForProperty("ContainerIdentityInfoAadTenantId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoAadTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerIdentityInfoServicePrincipalClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoServicePrincipalClientId = (string) content.GetValueForProperty("ContainerIdentityInfoServicePrincipalClientId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoServicePrincipalClientId, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerIdentityInfoAudience"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoAudience = (string) content.GetValueForProperty("ContainerIdentityInfoAudience",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerInternal)this).ContainerIdentityInfoAudience, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Base class for generic container of backup items
    [System.ComponentModel.TypeConverter(typeof(GenericContainerTypeConverter))]
    public partial interface IGenericContainer

    {

    }
}