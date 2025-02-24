// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.PowerShell;

    /// <summary>The definition of a scoping question.</summary>
    [System.ComponentModel.TypeConverter(typeof(ScopingQuestionTypeConverter))]
    public partial class ScopingQuestion
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ScopingQuestion"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestion" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestion DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ScopingQuestion(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ScopingQuestion"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestion" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestion DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ScopingQuestion(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ScopingQuestion" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ScopingQuestion" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestion FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ScopingQuestion"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ScopingQuestion(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("QuestionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).QuestionId = (string) content.GetValueForProperty("QuestionId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).QuestionId, global::System.Convert.ToString);
            }
            if (content.Contains("SuperiorQuestionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).SuperiorQuestionId = (string) content.GetValueForProperty("SuperiorQuestionId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).SuperiorQuestionId, global::System.Convert.ToString);
            }
            if (content.Contains("InputType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).InputType = (string) content.GetValueForProperty("InputType",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).InputType, global::System.Convert.ToString);
            }
            if (content.Contains("OptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).OptionId = (System.Collections.Generic.List<string>) content.GetValueForProperty("OptionId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).OptionId, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Rule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).Rule = (System.Collections.Generic.List<string>) content.GetValueForProperty("Rule",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).Rule, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ShowSubQuestionsValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).ShowSubQuestionsValue = (string) content.GetValueForProperty("ShowSubQuestionsValue",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).ShowSubQuestionsValue, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ScopingQuestion"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ScopingQuestion(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("QuestionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).QuestionId = (string) content.GetValueForProperty("QuestionId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).QuestionId, global::System.Convert.ToString);
            }
            if (content.Contains("SuperiorQuestionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).SuperiorQuestionId = (string) content.GetValueForProperty("SuperiorQuestionId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).SuperiorQuestionId, global::System.Convert.ToString);
            }
            if (content.Contains("InputType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).InputType = (string) content.GetValueForProperty("InputType",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).InputType, global::System.Convert.ToString);
            }
            if (content.Contains("OptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).OptionId = (System.Collections.Generic.List<string>) content.GetValueForProperty("OptionId",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).OptionId, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Rule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).Rule = (System.Collections.Generic.List<string>) content.GetValueForProperty("Rule",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).Rule, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ShowSubQuestionsValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).ShowSubQuestionsValue = (string) content.GetValueForProperty("ShowSubQuestionsValue",((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal)this).ShowSubQuestionsValue, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The definition of a scoping question.
    [System.ComponentModel.TypeConverter(typeof(ScopingQuestionTypeConverter))]
    public partial interface IScopingQuestion

    {

    }
}