// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>
    /// Warning object used by layers that have access to localized content, and propagate that to user
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(UserFacingWarningDetailTypeConverter))]
    public partial class UserFacingWarningDetail
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingWarningDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetail" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetail DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UserFacingWarningDetail(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingWarningDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetail" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetail DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UserFacingWarningDetail(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UserFacingWarningDetail" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="UserFacingWarningDetail" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetail FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.SerializationMode.IncludeAll)?.ToString();

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingWarningDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UserFacingWarningDetail(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Warning"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).Warning = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) content.GetValueForProperty("Warning",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).Warning, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).ResourceName = (string) content.GetValueForProperty("ResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).ResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("WarningInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) content.GetValueForProperty("WarningInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("WarningCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningCode = (string) content.GetValueForProperty("WarningCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningCode, global::System.Convert.ToString);
            }
            if (content.Contains("WarningDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>) content.GetValueForProperty("WarningDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("WarningIsRetryable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningIsRetryable = (bool?) content.GetValueForProperty("WarningIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WarningIsUserError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningIsUserError = (bool?) content.GetValueForProperty("WarningIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WarningProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) content.GetValueForProperty("WarningProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("WarningMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningMessage = (string) content.GetValueForProperty("WarningMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningMessage, global::System.Convert.ToString);
            }
            if (content.Contains("WarningRecommendedAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningRecommendedAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("WarningRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningRecommendedAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("WarningTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningTarget = (string) content.GetValueForProperty("WarningTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningTarget, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingWarningDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UserFacingWarningDetail(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Warning"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).Warning = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) content.GetValueForProperty("Warning",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).Warning, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).ResourceName = (string) content.GetValueForProperty("ResourceName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).ResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("WarningInnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningInnerError = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) content.GetValueForProperty("WarningInnerError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningInnerError, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("WarningCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningCode = (string) content.GetValueForProperty("WarningCode",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningCode, global::System.Convert.ToString);
            }
            if (content.Contains("WarningDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>) content.GetValueForProperty("WarningDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("WarningIsRetryable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningIsRetryable = (bool?) content.GetValueForProperty("WarningIsRetryable",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningIsRetryable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WarningIsUserError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningIsUserError = (bool?) content.GetValueForProperty("WarningIsUserError",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningIsUserError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WarningProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) content.GetValueForProperty("WarningProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningProperty, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingErrorPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("WarningMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningMessage = (string) content.GetValueForProperty("WarningMessage",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningMessage, global::System.Convert.ToString);
            }
            if (content.Contains("WarningRecommendedAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningRecommendedAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("WarningRecommendedAction",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningRecommendedAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("WarningTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningTarget = (string) content.GetValueForProperty("WarningTarget",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal)this).WarningTarget, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Warning object used by layers that have access to localized content, and propagate that to user
    [System.ComponentModel.TypeConverter(typeof(UserFacingWarningDetailTypeConverter))]
    public partial interface IUserFacingWarningDetail

    {

    }
}