// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>
    /// The requirements to validate customer address where the device needs to be shipped.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ValidateAddressTypeConverter))]
    public partial class ValidateAddress
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ValidateAddress"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddress" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddress DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ValidateAddress(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ValidateAddress"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddress" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddress DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ValidateAddress(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ValidateAddress" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ValidateAddress" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddress FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ValidateAddress"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ValidateAddress(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress) content.GetValueForProperty("ShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransportPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).TransportPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences) content.GetValueForProperty("TransportPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).TransportPreference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeviceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).DeviceType = (string) content.GetValueForProperty("DeviceType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).DeviceType, global::System.Convert.ToString);
            }
            if (content.Contains("Model"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).Model = (string) content.GetValueForProperty("Model",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).Model, global::System.Convert.ToString);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequestInternal)this).ValidationType = (string) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequestInternal)this).ValidationType, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressType = (string) content.GetValueForProperty("ShippingAddressType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressType, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStreetAddress1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStreetAddress1 = (string) content.GetValueForProperty("ShippingAddressStreetAddress1",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStreetAddress1, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStreetAddress2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStreetAddress2 = (string) content.GetValueForProperty("ShippingAddressStreetAddress2",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStreetAddress2, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStreetAddress3"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStreetAddress3 = (string) content.GetValueForProperty("ShippingAddressStreetAddress3",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStreetAddress3, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressCity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressCity = (string) content.GetValueForProperty("ShippingAddressCity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressCity, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStateOrProvince"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStateOrProvince = (string) content.GetValueForProperty("ShippingAddressStateOrProvince",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStateOrProvince, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressCountry = (string) content.GetValueForProperty("ShippingAddressCountry",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressCountry, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressPostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressPostalCode = (string) content.GetValueForProperty("ShippingAddressPostalCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressPostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressZipExtendedCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressZipExtendedCode = (string) content.GetValueForProperty("ShippingAddressZipExtendedCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressZipExtendedCode, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressCompanyName = (string) content.GetValueForProperty("ShippingAddressCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressSkipAddressValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressSkipAddressValidation = (bool?) content.GetValueForProperty("ShippingAddressSkipAddressValidation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressSkipAddressValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ShippingAddressTaxIdentificationNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressTaxIdentificationNumber = (string) content.GetValueForProperty("ShippingAddressTaxIdentificationNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressTaxIdentificationNumber, global::System.Convert.ToString);
            }
            if (content.Contains("TransportPreferencePreferredShipmentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).TransportPreferencePreferredShipmentType = (string) content.GetValueForProperty("TransportPreferencePreferredShipmentType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).TransportPreferencePreferredShipmentType, global::System.Convert.ToString);
            }
            if (content.Contains("TransportPreferenceIsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).TransportPreferenceIsUpdated = (bool?) content.GetValueForProperty("TransportPreferenceIsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).TransportPreferenceIsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ValidateAddress"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ValidateAddress(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress) content.GetValueForProperty("ShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransportPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).TransportPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences) content.GetValueForProperty("TransportPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).TransportPreference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeviceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).DeviceType = (string) content.GetValueForProperty("DeviceType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).DeviceType, global::System.Convert.ToString);
            }
            if (content.Contains("Model"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).Model = (string) content.GetValueForProperty("Model",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).Model, global::System.Convert.ToString);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequestInternal)this).ValidationType = (string) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequestInternal)this).ValidationType, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressType = (string) content.GetValueForProperty("ShippingAddressType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressType, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStreetAddress1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStreetAddress1 = (string) content.GetValueForProperty("ShippingAddressStreetAddress1",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStreetAddress1, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStreetAddress2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStreetAddress2 = (string) content.GetValueForProperty("ShippingAddressStreetAddress2",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStreetAddress2, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStreetAddress3"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStreetAddress3 = (string) content.GetValueForProperty("ShippingAddressStreetAddress3",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStreetAddress3, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressCity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressCity = (string) content.GetValueForProperty("ShippingAddressCity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressCity, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStateOrProvince"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStateOrProvince = (string) content.GetValueForProperty("ShippingAddressStateOrProvince",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressStateOrProvince, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressCountry = (string) content.GetValueForProperty("ShippingAddressCountry",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressCountry, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressPostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressPostalCode = (string) content.GetValueForProperty("ShippingAddressPostalCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressPostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressZipExtendedCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressZipExtendedCode = (string) content.GetValueForProperty("ShippingAddressZipExtendedCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressZipExtendedCode, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressCompanyName = (string) content.GetValueForProperty("ShippingAddressCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressSkipAddressValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressSkipAddressValidation = (bool?) content.GetValueForProperty("ShippingAddressSkipAddressValidation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressSkipAddressValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ShippingAddressTaxIdentificationNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressTaxIdentificationNumber = (string) content.GetValueForProperty("ShippingAddressTaxIdentificationNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).ShippingAddressTaxIdentificationNumber, global::System.Convert.ToString);
            }
            if (content.Contains("TransportPreferencePreferredShipmentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).TransportPreferencePreferredShipmentType = (string) content.GetValueForProperty("TransportPreferencePreferredShipmentType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).TransportPreferencePreferredShipmentType, global::System.Convert.ToString);
            }
            if (content.Contains("TransportPreferenceIsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).TransportPreferenceIsUpdated = (bool?) content.GetValueForProperty("TransportPreferenceIsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal)this).TransportPreferenceIsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// The requirements to validate customer address where the device needs to be shipped.
    [System.ComponentModel.TypeConverter(typeof(ValidateAddressTypeConverter))]
    public partial interface IValidateAddress

    {

    }
}