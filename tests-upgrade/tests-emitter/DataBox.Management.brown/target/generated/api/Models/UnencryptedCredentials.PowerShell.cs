// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Unencrypted credentials for accessing device.</summary>
    [System.ComponentModel.TypeConverter(typeof(UnencryptedCredentialsTypeConverter))]
    public partial class UnencryptedCredentials
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UnencryptedCredentials"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentials" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentials DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UnencryptedCredentials(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UnencryptedCredentials"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentials" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentials DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UnencryptedCredentials(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UnencryptedCredentials" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="UnencryptedCredentials" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentials FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UnencryptedCredentials"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UnencryptedCredentials(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("JobSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecret = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecrets) content.GetValueForProperty("JobSecret",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecret, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobSecretsTypeConverter.ConvertFrom);
            }
            if (content.Contains("JobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobName = (string) content.GetValueForProperty("JobName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobName, global::System.Convert.ToString);
            }
            if (content.Contains("JobSecretDcAccessSecurityCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecretDcAccessSecurityCode = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCode) content.GetValueForProperty("JobSecretDcAccessSecurityCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecretDcAccessSecurityCode, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DcAccessSecurityCodeTypeConverter.ConvertFrom);
            }
            if (content.Contains("JobSecretError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecretError = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError) content.GetValueForProperty("JobSecretError",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecretError, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("JobSecretJobSecretsType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecretJobSecretsType = (string) content.GetValueForProperty("JobSecretJobSecretsType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecretJobSecretsType, global::System.Convert.ToString);
            }
            if (content.Contains("DcAccessSecurityCodeReverseDcAccessCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).DcAccessSecurityCodeReverseDcAccessCode = (string) content.GetValueForProperty("DcAccessSecurityCodeReverseDcAccessCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).DcAccessSecurityCodeReverseDcAccessCode, global::System.Convert.ToString);
            }
            if (content.Contains("DcAccessSecurityCodeForwardDcAccessCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).DcAccessSecurityCodeForwardDcAccessCode = (string) content.GetValueForProperty("DcAccessSecurityCodeForwardDcAccessCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).DcAccessSecurityCodeForwardDcAccessCode, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).AdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AdditionalErrorInfo1TypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Target, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UnencryptedCredentials"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UnencryptedCredentials(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("JobSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecret = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobSecrets) content.GetValueForProperty("JobSecret",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecret, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobSecretsTypeConverter.ConvertFrom);
            }
            if (content.Contains("JobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobName = (string) content.GetValueForProperty("JobName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobName, global::System.Convert.ToString);
            }
            if (content.Contains("JobSecretDcAccessSecurityCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecretDcAccessSecurityCode = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDcAccessSecurityCode) content.GetValueForProperty("JobSecretDcAccessSecurityCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecretDcAccessSecurityCode, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DcAccessSecurityCodeTypeConverter.ConvertFrom);
            }
            if (content.Contains("JobSecretError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecretError = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError) content.GetValueForProperty("JobSecretError",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecretError, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("JobSecretJobSecretsType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecretJobSecretsType = (string) content.GetValueForProperty("JobSecretJobSecretsType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).JobSecretJobSecretsType, global::System.Convert.ToString);
            }
            if (content.Contains("DcAccessSecurityCodeReverseDcAccessCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).DcAccessSecurityCodeReverseDcAccessCode = (string) content.GetValueForProperty("DcAccessSecurityCodeReverseDcAccessCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).DcAccessSecurityCodeReverseDcAccessCode, global::System.Convert.ToString);
            }
            if (content.Contains("DcAccessSecurityCodeForwardDcAccessCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).DcAccessSecurityCodeForwardDcAccessCode = (string) content.GetValueForProperty("DcAccessSecurityCodeForwardDcAccessCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).DcAccessSecurityCodeForwardDcAccessCode, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).AdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AdditionalErrorInfo1TypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUnencryptedCredentialsInternal)this).Target, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Unencrypted credentials for accessing device.
    [System.ComponentModel.TypeConverter(typeof(UnencryptedCredentialsTypeConverter))]
    public partial interface IUnencryptedCredentials

    {

    }
}