// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.PowerShell;

    /// <summary>Properties of the certificate.</summary>
    [System.ComponentModel.TypeConverter(typeof(CertificateTypeConverter))]
    public partial class Certificate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.Certificate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Certificate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Revocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).Revocation = (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocation) content.GetValueForProperty("Revocation",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).Revocation, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.RevocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("SerialNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).SerialNumber = (string) content.GetValueForProperty("SerialNumber",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).SerialNumber, global::System.Convert.ToString);
            }
            if (content.Contains("EnhancedKeyUsage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).EnhancedKeyUsage = (string) content.GetValueForProperty("EnhancedKeyUsage",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).EnhancedKeyUsage, global::System.Convert.ToString);
            }
            if (content.Contains("SubjectName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).SubjectName = (string) content.GetValueForProperty("SubjectName",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).SubjectName, global::System.Convert.ToString);
            }
            if (content.Contains("Thumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).Thumbprint = (string) content.GetValueForProperty("Thumbprint",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).Thumbprint, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).CreatedDate = (string) content.GetValueForProperty("CreatedDate",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).CreatedDate, global::System.Convert.ToString);
            }
            if (content.Contains("ExpiryDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).ExpiryDate = (string) content.GetValueForProperty("ExpiryDate",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).ExpiryDate, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("RevocationRemark"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationRemark = (string) content.GetValueForProperty("RevocationRemark",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationRemark, global::System.Convert.ToString);
            }
            if (content.Contains("RevocationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationStatus = (string) content.GetValueForProperty("RevocationStatus",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationStatus, global::System.Convert.ToString);
            }
            if (content.Contains("RevocationRequestedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationRequestedAt = (global::System.DateTime?) content.GetValueForProperty("RevocationRequestedAt",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationRequestedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RevocationEffectiveAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationEffectiveAt = (global::System.DateTime?) content.GetValueForProperty("RevocationEffectiveAt",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationEffectiveAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RevocationReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationReason = (string) content.GetValueForProperty("RevocationReason",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationReason, global::System.Convert.ToString);
            }
            if (content.Contains("RevocationFailureReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationFailureReason = (string) content.GetValueForProperty("RevocationFailureReason",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationFailureReason, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.Certificate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Certificate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Revocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).Revocation = (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocation) content.GetValueForProperty("Revocation",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).Revocation, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.RevocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("SerialNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).SerialNumber = (string) content.GetValueForProperty("SerialNumber",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).SerialNumber, global::System.Convert.ToString);
            }
            if (content.Contains("EnhancedKeyUsage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).EnhancedKeyUsage = (string) content.GetValueForProperty("EnhancedKeyUsage",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).EnhancedKeyUsage, global::System.Convert.ToString);
            }
            if (content.Contains("SubjectName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).SubjectName = (string) content.GetValueForProperty("SubjectName",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).SubjectName, global::System.Convert.ToString);
            }
            if (content.Contains("Thumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).Thumbprint = (string) content.GetValueForProperty("Thumbprint",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).Thumbprint, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).CreatedDate = (string) content.GetValueForProperty("CreatedDate",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).CreatedDate, global::System.Convert.ToString);
            }
            if (content.Contains("ExpiryDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).ExpiryDate = (string) content.GetValueForProperty("ExpiryDate",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).ExpiryDate, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("RevocationRemark"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationRemark = (string) content.GetValueForProperty("RevocationRemark",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationRemark, global::System.Convert.ToString);
            }
            if (content.Contains("RevocationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationStatus = (string) content.GetValueForProperty("RevocationStatus",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationStatus, global::System.Convert.ToString);
            }
            if (content.Contains("RevocationRequestedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationRequestedAt = (global::System.DateTime?) content.GetValueForProperty("RevocationRequestedAt",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationRequestedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RevocationEffectiveAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationEffectiveAt = (global::System.DateTime?) content.GetValueForProperty("RevocationEffectiveAt",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationEffectiveAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RevocationReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationReason = (string) content.GetValueForProperty("RevocationReason",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationReason, global::System.Convert.ToString);
            }
            if (content.Contains("RevocationFailureReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationFailureReason = (string) content.GetValueForProperty("RevocationFailureReason",((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateInternal)this).RevocationFailureReason, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.Certificate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Certificate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.Certificate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Certificate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Certificate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Certificate" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Properties of the certificate.
    [System.ComponentModel.TypeConverter(typeof(CertificateTypeConverter))]
    public partial interface ICertificate

    {

    }
}