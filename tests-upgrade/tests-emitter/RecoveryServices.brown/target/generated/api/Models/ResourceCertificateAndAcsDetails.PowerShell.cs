// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>Certificate details representing the Vault credentials for ACS.</summary>
    [System.ComponentModel.TypeConverter(typeof(ResourceCertificateAndAcsDetailsTypeConverter))]
    public partial class ResourceCertificateAndAcsDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ResourceCertificateAndAcsDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ResourceCertificateAndAcsDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ResourceCertificateAndAcsDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ResourceCertificateAndAcsDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ResourceCertificateAndAcsDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ResourceCertificateAndAcsDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ResourceCertificateAndAcsDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ResourceCertificateAndAcsDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("GlobalAcsNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetailsInternal)this).GlobalAcsNamespace = (string) content.GetValueForProperty("GlobalAcsNamespace",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetailsInternal)this).GlobalAcsNamespace, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalAcsHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetailsInternal)this).GlobalAcsHostName = (string) content.GetValueForProperty("GlobalAcsHostName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetailsInternal)this).GlobalAcsHostName, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalAcsRpRealm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetailsInternal)this).GlobalAcsRpRealm = (string) content.GetValueForProperty("GlobalAcsRpRealm",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetailsInternal)this).GlobalAcsRpRealm, global::System.Convert.ToString);
            }
            if (content.Contains("AuthType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).AuthType = (string) content.GetValueForProperty("AuthType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).AuthType, global::System.Convert.ToString);
            }
            if (content.Contains("Certificate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Certificate = (byte[]) content.GetValueForProperty("Certificate",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Certificate, i => i);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("Issuer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Issuer = (string) content.GetValueForProperty("Issuer",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Issuer, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).ResourceId = (long?) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).ResourceId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Subject"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Subject = (string) content.GetValueForProperty("Subject",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Subject, global::System.Convert.ToString);
            }
            if (content.Contains("Thumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Thumbprint = (string) content.GetValueForProperty("Thumbprint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Thumbprint, global::System.Convert.ToString);
            }
            if (content.Contains("ValidFrom"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).ValidFrom = (global::System.DateTime?) content.GetValueForProperty("ValidFrom",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).ValidFrom, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ValidTo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).ValidTo = (global::System.DateTime?) content.GetValueForProperty("ValidTo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).ValidTo, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ResourceCertificateAndAcsDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ResourceCertificateAndAcsDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("GlobalAcsNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetailsInternal)this).GlobalAcsNamespace = (string) content.GetValueForProperty("GlobalAcsNamespace",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetailsInternal)this).GlobalAcsNamespace, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalAcsHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetailsInternal)this).GlobalAcsHostName = (string) content.GetValueForProperty("GlobalAcsHostName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetailsInternal)this).GlobalAcsHostName, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalAcsRpRealm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetailsInternal)this).GlobalAcsRpRealm = (string) content.GetValueForProperty("GlobalAcsRpRealm",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateAndAcsDetailsInternal)this).GlobalAcsRpRealm, global::System.Convert.ToString);
            }
            if (content.Contains("AuthType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).AuthType = (string) content.GetValueForProperty("AuthType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).AuthType, global::System.Convert.ToString);
            }
            if (content.Contains("Certificate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Certificate = (byte[]) content.GetValueForProperty("Certificate",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Certificate, i => i);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("Issuer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Issuer = (string) content.GetValueForProperty("Issuer",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Issuer, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).ResourceId = (long?) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).ResourceId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Subject"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Subject = (string) content.GetValueForProperty("Subject",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Subject, global::System.Convert.ToString);
            }
            if (content.Contains("Thumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Thumbprint = (string) content.GetValueForProperty("Thumbprint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).Thumbprint, global::System.Convert.ToString);
            }
            if (content.Contains("ValidFrom"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).ValidFrom = (global::System.DateTime?) content.GetValueForProperty("ValidFrom",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).ValidFrom, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ValidTo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).ValidTo = (global::System.DateTime?) content.GetValueForProperty("ValidTo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)this).ValidTo, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Certificate details representing the Vault credentials for ACS.
    [System.ComponentModel.TypeConverter(typeof(ResourceCertificateAndAcsDetailsTypeConverter))]
    public partial interface IResourceCertificateAndAcsDetails

    {

    }
}