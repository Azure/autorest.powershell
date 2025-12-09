// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.PowerShell;

    /// <summary>The properties of an administrator.</summary>
    [System.ComponentModel.TypeConverter(typeof(AdministratorPropertiesTypeConverter))]
    public partial class AdministratorProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.AdministratorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AdministratorProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AdministratorType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).AdministratorType = (string) content.GetValueForProperty("AdministratorType",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).AdministratorType, global::System.Convert.ToString);
            }
            if (content.Contains("Login"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).Login = (string) content.GetValueForProperty("Login",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).Login, global::System.Convert.ToString);
            }
            if (content.Contains("Sid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).Sid = (string) content.GetValueForProperty("Sid",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).Sid, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).IdentityResourceId = (string) content.GetValueForProperty("IdentityResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).IdentityResourceId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.AdministratorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AdministratorProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AdministratorType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).AdministratorType = (string) content.GetValueForProperty("AdministratorType",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).AdministratorType, global::System.Convert.ToString);
            }
            if (content.Contains("Login"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).Login = (string) content.GetValueForProperty("Login",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).Login, global::System.Convert.ToString);
            }
            if (content.Contains("Sid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).Sid = (string) content.GetValueForProperty("Sid",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).Sid, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).IdentityResourceId = (string) content.GetValueForProperty("IdentityResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorPropertiesInternal)this).IdentityResourceId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.AdministratorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AdministratorProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.AdministratorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AdministratorProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AdministratorProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AdministratorProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdministratorProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The properties of an administrator.
    [System.ComponentModel.TypeConverter(typeof(AdministratorPropertiesTypeConverter))]
    public partial interface IAdministratorProperties

    {

    }
}