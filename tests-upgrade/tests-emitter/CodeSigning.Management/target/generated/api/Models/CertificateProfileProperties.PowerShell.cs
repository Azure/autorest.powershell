// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.PowerShell;

    /// <summary>Properties of the certificate profile.</summary>
    [System.ComponentModel.TypeConverter(typeof(CertificateProfilePropertiesTypeConverter))]
    public partial class CertificateProfileProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateProfileProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CertificateProfileProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProfileType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).ProfileType = (string) content.GetValueForProperty("ProfileType",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).ProfileType, global::System.Convert.ToString);
            }
            if (content.Contains("CommonName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).CommonName = (string) content.GetValueForProperty("CommonName",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).CommonName, global::System.Convert.ToString);
            }
            if (content.Contains("Organization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Organization = (string) content.GetValueForProperty("Organization",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Organization, global::System.Convert.ToString);
            }
            if (content.Contains("OrganizationUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).OrganizationUnit = (string) content.GetValueForProperty("OrganizationUnit",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).OrganizationUnit, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).StreetAddress = (string) content.GetValueForProperty("StreetAddress",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).StreetAddress, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeStreetAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeStreetAddress = (bool?) content.GetValueForProperty("IncludeStreetAddress",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeStreetAddress, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("City"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).City = (string) content.GetValueForProperty("City",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).City, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeCity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeCity = (bool?) content.GetValueForProperty("IncludeCity",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeCity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeState = (bool?) content.GetValueForProperty("IncludeState",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeState, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Country"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Country = (string) content.GetValueForProperty("Country",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Country, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeCountry = (bool?) content.GetValueForProperty("IncludeCountry",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeCountry, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).PostalCode = (string) content.GetValueForProperty("PostalCode",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).PostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("IncludePostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludePostalCode = (bool?) content.GetValueForProperty("IncludePostalCode",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludePostalCode, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnhancedKeyUsage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).EnhancedKeyUsage = (string) content.GetValueForProperty("EnhancedKeyUsage",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).EnhancedKeyUsage, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityValidationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IdentityValidationId = (string) content.GetValueForProperty("IdentityValidationId",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IdentityValidationId, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Certificate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Certificate = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate>) content.GetValueForProperty("Certificate",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Certificate, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate>(__y, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateProfileProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CertificateProfileProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProfileType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).ProfileType = (string) content.GetValueForProperty("ProfileType",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).ProfileType, global::System.Convert.ToString);
            }
            if (content.Contains("CommonName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).CommonName = (string) content.GetValueForProperty("CommonName",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).CommonName, global::System.Convert.ToString);
            }
            if (content.Contains("Organization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Organization = (string) content.GetValueForProperty("Organization",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Organization, global::System.Convert.ToString);
            }
            if (content.Contains("OrganizationUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).OrganizationUnit = (string) content.GetValueForProperty("OrganizationUnit",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).OrganizationUnit, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).StreetAddress = (string) content.GetValueForProperty("StreetAddress",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).StreetAddress, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeStreetAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeStreetAddress = (bool?) content.GetValueForProperty("IncludeStreetAddress",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeStreetAddress, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("City"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).City = (string) content.GetValueForProperty("City",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).City, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeCity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeCity = (bool?) content.GetValueForProperty("IncludeCity",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeCity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeState = (bool?) content.GetValueForProperty("IncludeState",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeState, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Country"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Country = (string) content.GetValueForProperty("Country",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Country, global::System.Convert.ToString);
            }
            if (content.Contains("IncludeCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeCountry = (bool?) content.GetValueForProperty("IncludeCountry",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludeCountry, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).PostalCode = (string) content.GetValueForProperty("PostalCode",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).PostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("IncludePostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludePostalCode = (bool?) content.GetValueForProperty("IncludePostalCode",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IncludePostalCode, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnhancedKeyUsage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).EnhancedKeyUsage = (string) content.GetValueForProperty("EnhancedKeyUsage",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).EnhancedKeyUsage, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityValidationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IdentityValidationId = (string) content.GetValueForProperty("IdentityValidationId",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).IdentityValidationId, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Certificate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Certificate = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate>) content.GetValueForProperty("Certificate",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)this).Certificate, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate>(__y, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateProfileProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CertificateProfileProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateProfileProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CertificateProfileProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CertificateProfileProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CertificateProfileProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Properties of the certificate profile.
    [System.ComponentModel.TypeConverter(typeof(CertificateProfilePropertiesTypeConverter))]
    public partial interface ICertificateProfileProperties

    {

    }
}