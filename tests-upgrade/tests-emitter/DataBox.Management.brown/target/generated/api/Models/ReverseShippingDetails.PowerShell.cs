// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Reverse Shipping Address and contact details for a job.</summary>
    [System.ComponentModel.TypeConverter(typeof(ReverseShippingDetailsTypeConverter))]
    public partial class ReverseShippingDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ReverseShippingDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReverseShippingDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ReverseShippingDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReverseShippingDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReverseShippingDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ReverseShippingDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ReverseShippingDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReverseShippingDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfo) content.GetValueForProperty("ContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ContactInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress) content.GetValueForProperty("ShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("IsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).IsUpdated = (bool?) content.GetValueForProperty("IsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).IsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ShippingAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressType = (string) content.GetValueForProperty("ShippingAddressType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressType, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailContactName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailContactName = (string) content.GetValueForProperty("ContactDetailContactName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailContactName, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailPhone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailPhone = (string) content.GetValueForProperty("ContactDetailPhone",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailPhone, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailPhoneExtension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailPhoneExtension = (string) content.GetValueForProperty("ContactDetailPhoneExtension",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailPhoneExtension, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailMobile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailMobile = (string) content.GetValueForProperty("ContactDetailMobile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailMobile, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStreetAddress1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStreetAddress1 = (string) content.GetValueForProperty("ShippingAddressStreetAddress1",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStreetAddress1, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStreetAddress2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStreetAddress2 = (string) content.GetValueForProperty("ShippingAddressStreetAddress2",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStreetAddress2, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStreetAddress3"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStreetAddress3 = (string) content.GetValueForProperty("ShippingAddressStreetAddress3",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStreetAddress3, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressCity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressCity = (string) content.GetValueForProperty("ShippingAddressCity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressCity, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStateOrProvince"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStateOrProvince = (string) content.GetValueForProperty("ShippingAddressStateOrProvince",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStateOrProvince, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressCountry = (string) content.GetValueForProperty("ShippingAddressCountry",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressCountry, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressPostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressPostalCode = (string) content.GetValueForProperty("ShippingAddressPostalCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressPostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressZipExtendedCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressZipExtendedCode = (string) content.GetValueForProperty("ShippingAddressZipExtendedCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressZipExtendedCode, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressCompanyName = (string) content.GetValueForProperty("ShippingAddressCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressSkipAddressValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressSkipAddressValidation = (bool?) content.GetValueForProperty("ShippingAddressSkipAddressValidation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressSkipAddressValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ShippingAddressTaxIdentificationNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressTaxIdentificationNumber = (string) content.GetValueForProperty("ShippingAddressTaxIdentificationNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressTaxIdentificationNumber, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ReverseShippingDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReverseShippingDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfo) content.GetValueForProperty("ContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ContactInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress) content.GetValueForProperty("ShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("IsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).IsUpdated = (bool?) content.GetValueForProperty("IsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).IsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ShippingAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressType = (string) content.GetValueForProperty("ShippingAddressType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressType, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailContactName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailContactName = (string) content.GetValueForProperty("ContactDetailContactName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailContactName, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailPhone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailPhone = (string) content.GetValueForProperty("ContactDetailPhone",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailPhone, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailPhoneExtension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailPhoneExtension = (string) content.GetValueForProperty("ContactDetailPhoneExtension",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailPhoneExtension, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailMobile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailMobile = (string) content.GetValueForProperty("ContactDetailMobile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ContactDetailMobile, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStreetAddress1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStreetAddress1 = (string) content.GetValueForProperty("ShippingAddressStreetAddress1",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStreetAddress1, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStreetAddress2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStreetAddress2 = (string) content.GetValueForProperty("ShippingAddressStreetAddress2",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStreetAddress2, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStreetAddress3"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStreetAddress3 = (string) content.GetValueForProperty("ShippingAddressStreetAddress3",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStreetAddress3, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressCity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressCity = (string) content.GetValueForProperty("ShippingAddressCity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressCity, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressStateOrProvince"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStateOrProvince = (string) content.GetValueForProperty("ShippingAddressStateOrProvince",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressStateOrProvince, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressCountry = (string) content.GetValueForProperty("ShippingAddressCountry",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressCountry, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressPostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressPostalCode = (string) content.GetValueForProperty("ShippingAddressPostalCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressPostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressZipExtendedCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressZipExtendedCode = (string) content.GetValueForProperty("ShippingAddressZipExtendedCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressZipExtendedCode, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressCompanyName = (string) content.GetValueForProperty("ShippingAddressCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingAddressSkipAddressValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressSkipAddressValidation = (bool?) content.GetValueForProperty("ShippingAddressSkipAddressValidation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressSkipAddressValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ShippingAddressTaxIdentificationNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressTaxIdentificationNumber = (string) content.GetValueForProperty("ShippingAddressTaxIdentificationNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)this).ShippingAddressTaxIdentificationNumber, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

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
    /// Reverse Shipping Address and contact details for a job.
    [System.ComponentModel.TypeConverter(typeof(ReverseShippingDetailsTypeConverter))]
    public partial interface IReverseShippingDetails

    {

    }
}