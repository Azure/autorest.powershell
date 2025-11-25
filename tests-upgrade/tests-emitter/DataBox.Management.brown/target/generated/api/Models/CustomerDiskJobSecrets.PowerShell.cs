// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>The secrets related to customer disk job.</summary>
    [System.ComponentModel.TypeConverter(typeof(CustomerDiskJobSecretsTypeConverter))]
    public partial class CustomerDiskJobSecrets
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CustomerDiskJobSecrets"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CustomerDiskJobSecrets(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DiskSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICustomerDiskJobSecretsInternal)this).DiskSecret = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDiskSecret>) content.GetValueForProperty("DiskSecret",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICustomerDiskJobSecretsInternal)this).DiskSecret, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDiskSecret>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DiskSecretTypeConverter.ConvertFrom));
            }
            if (content.Contains("CarrierAccountNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICustomerDiskJobSecretsInternal)this).CarrierAccountNumber = (System.Security.SecureString) content.GetValueForProperty("CarrierAccountNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICustomerDiskJobSecretsInternal)this).CarrierAccountNumber, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("DcAccessSecurityCodeReverseDcAccessCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).DcAccessSecurityCodeReverseDcAccessCode = (string) content.GetValueForProperty("DcAccessSecurityCodeReverseDcAccessCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).DcAccessSecurityCodeReverseDcAccessCode, global::System.Convert.ToString);
            }
            if (content.Contains("DcAccessSecurityCodeForwardDcAccessCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).DcAccessSecurityCodeForwardDcAccessCode = (string) content.GetValueForProperty("DcAccessSecurityCodeForwardDcAccessCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).DcAccessSecurityCodeForwardDcAccessCode, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).AdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AdditionalErrorInfo1TypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("DcAccessSecurityCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).DcAccessSecurityCode = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCode) content.GetValueForProperty("DcAccessSecurityCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).DcAccessSecurityCode, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DcAccessSecurityCodeTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Type, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CustomerDiskJobSecrets"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CustomerDiskJobSecrets(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DiskSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICustomerDiskJobSecretsInternal)this).DiskSecret = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDiskSecret>) content.GetValueForProperty("DiskSecret",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICustomerDiskJobSecretsInternal)this).DiskSecret, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDiskSecret>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DiskSecretTypeConverter.ConvertFrom));
            }
            if (content.Contains("CarrierAccountNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICustomerDiskJobSecretsInternal)this).CarrierAccountNumber = (System.Security.SecureString) content.GetValueForProperty("CarrierAccountNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICustomerDiskJobSecretsInternal)this).CarrierAccountNumber, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("DcAccessSecurityCodeReverseDcAccessCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).DcAccessSecurityCodeReverseDcAccessCode = (string) content.GetValueForProperty("DcAccessSecurityCodeReverseDcAccessCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).DcAccessSecurityCodeReverseDcAccessCode, global::System.Convert.ToString);
            }
            if (content.Contains("DcAccessSecurityCodeForwardDcAccessCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).DcAccessSecurityCodeForwardDcAccessCode = (string) content.GetValueForProperty("DcAccessSecurityCodeForwardDcAccessCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).DcAccessSecurityCodeForwardDcAccessCode, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).AdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AdditionalErrorInfo1TypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("DcAccessSecurityCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).DcAccessSecurityCode = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCode) content.GetValueForProperty("DcAccessSecurityCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).DcAccessSecurityCode, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DcAccessSecurityCodeTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecretsInternal)this).Type, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CustomerDiskJobSecrets"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICustomerDiskJobSecrets" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICustomerDiskJobSecrets DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CustomerDiskJobSecrets(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CustomerDiskJobSecrets"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICustomerDiskJobSecrets" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICustomerDiskJobSecrets DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CustomerDiskJobSecrets(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CustomerDiskJobSecrets" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CustomerDiskJobSecrets" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICustomerDiskJobSecrets FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The secrets related to customer disk job.
    [System.ComponentModel.TypeConverter(typeof(CustomerDiskJobSecretsTypeConverter))]
    public partial interface ICustomerDiskJobSecrets

    {

    }
}