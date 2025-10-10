// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(VerificationCodeResponsePropertiesTypeConverter))]
    public partial class VerificationCodeResponseProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.VerificationCodeResponseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VerificationCodeResponseProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.VerificationCodeResponseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VerificationCodeResponseProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VerificationCodeResponseProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="VerificationCodeResponseProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.SerializationMode.IncludeAll)?.ToString();

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.VerificationCodeResponseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VerificationCodeResponseProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VerificationCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).VerificationCode = (string) content.GetValueForProperty("VerificationCode",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).VerificationCode, global::System.Convert.ToString);
            }
            if (content.Contains("Subject"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Subject = (string) content.GetValueForProperty("Subject",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Subject, global::System.Convert.ToString);
            }
            if (content.Contains("Expiry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Expiry = (string) content.GetValueForProperty("Expiry",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Expiry, global::System.Convert.ToString);
            }
            if (content.Contains("Thumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Thumbprint = (string) content.GetValueForProperty("Thumbprint",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Thumbprint, global::System.Convert.ToString);
            }
            if (content.Contains("IsVerified"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).IsVerified = (bool?) content.GetValueForProperty("IsVerified",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).IsVerified, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Certificate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Certificate = (byte[]) content.GetValueForProperty("Certificate",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Certificate, i => i);
            }
            if (content.Contains("Created"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Created = (string) content.GetValueForProperty("Created",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Created, global::System.Convert.ToString);
            }
            if (content.Contains("Updated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Updated = (string) content.GetValueForProperty("Updated",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Updated, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.VerificationCodeResponseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VerificationCodeResponseProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VerificationCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).VerificationCode = (string) content.GetValueForProperty("VerificationCode",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).VerificationCode, global::System.Convert.ToString);
            }
            if (content.Contains("Subject"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Subject = (string) content.GetValueForProperty("Subject",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Subject, global::System.Convert.ToString);
            }
            if (content.Contains("Expiry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Expiry = (string) content.GetValueForProperty("Expiry",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Expiry, global::System.Convert.ToString);
            }
            if (content.Contains("Thumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Thumbprint = (string) content.GetValueForProperty("Thumbprint",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Thumbprint, global::System.Convert.ToString);
            }
            if (content.Contains("IsVerified"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).IsVerified = (bool?) content.GetValueForProperty("IsVerified",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).IsVerified, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Certificate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Certificate = (byte[]) content.GetValueForProperty("Certificate",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Certificate, i => i);
            }
            if (content.Contains("Created"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Created = (string) content.GetValueForProperty("Created",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Created, global::System.Convert.ToString);
            }
            if (content.Contains("Updated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Updated = (string) content.GetValueForProperty("Updated",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)this).Updated, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    [System.ComponentModel.TypeConverter(typeof(VerificationCodeResponsePropertiesTypeConverter))]
    public partial interface IVerificationCodeResponseProperties

    {

    }
}