// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>The definition of a scoping question.</summary>
    public partial class ScopingQuestion :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestion,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal
    {

        /// <summary>Backing field for <see cref="InputType" /> property.</summary>
        private string _inputType;

        /// <summary>Input type of the question answer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string InputType { get => this._inputType; }

        /// <summary>Internal Acessors for InputType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal.InputType { get => this._inputType; set { {_inputType = value;} } }

        /// <summary>Internal Acessors for OptionId</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal.OptionId { get => this._optionId; set { {_optionId = value;} } }

        /// <summary>Internal Acessors for QuestionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal.QuestionId { get => this._questionId; set { {_questionId = value;} } }

        /// <summary>Internal Acessors for Rule</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal.Rule { get => this._rule; set { {_rule = value;} } }

        /// <summary>Internal Acessors for ShowSubQuestionsValue</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal.ShowSubQuestionsValue { get => this._showSubQuestionsValue; set { {_showSubQuestionsValue = value;} } }

        /// <summary>Internal Acessors for SuperiorQuestionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingQuestionInternal.SuperiorQuestionId { get => this._superiorQuestionId; set { {_superiorQuestionId = value;} } }

        /// <summary>Backing field for <see cref="OptionId" /> property.</summary>
        private System.Collections.Generic.List<string> _optionId;

        /// <summary>Option id list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> OptionId { get => this._optionId; }

        /// <summary>Backing field for <see cref="QuestionId" /> property.</summary>
        private string _questionId;

        /// <summary>Question id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string QuestionId { get => this._questionId; }

        /// <summary>Backing field for <see cref="Rule" /> property.</summary>
        private System.Collections.Generic.List<string> _rule;

        /// <summary>The rule of the question.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Rule { get => this._rule; }

        /// <summary>Backing field for <see cref="ShowSubQuestionsValue" /> property.</summary>
        private string _showSubQuestionsValue;

        /// <summary>The answer value to show the sub questions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ShowSubQuestionsValue { get => this._showSubQuestionsValue; }

        /// <summary>Backing field for <see cref="SuperiorQuestionId" /> property.</summary>
        private string _superiorQuestionId;

        /// <summary>Superior question id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string SuperiorQuestionId { get => this._superiorQuestionId; }

        /// <summary>Creates an new <see cref="ScopingQuestion" /> instance.</summary>
        public ScopingQuestion()
        {

        }
    }
    /// The definition of a scoping question.
    public partial interface IScopingQuestion :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>Input type of the question answer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Input type of the question answer.",
        SerializedName = @"inputType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("None", "Text", "Email", "MultilineText", "Url", "Number", "Boolean", "Telephone", "YesNoNa", "Date", "YearPicker", "SingleSelection", "SingleSelectDropdown", "MultiSelectCheckbox", "MultiSelectDropdown", "MultiSelectDropdownCustom", "Group", "Upload")]
        string InputType { get;  }
        /// <summary>Option id list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Option id list.",
        SerializedName = @"optionIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> OptionId { get;  }
        /// <summary>Question id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Question id.",
        SerializedName = @"questionId",
        PossibleTypes = new [] { typeof(string) })]
        string QuestionId { get;  }
        /// <summary>The rule of the question.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The rule of the question.",
        SerializedName = @"rules",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Required", "CharLength", "Url", "Urls", "Domains", "USPrivacyShield", "PublicSOX", "CreditCardPCI", "AzureApplication", "ValidGuid", "PublisherVerification", "DynamicDropdown", "PreventNonEnglishChar", "ValidEmail")]
        System.Collections.Generic.List<string> Rule { get;  }
        /// <summary>The answer value to show the sub questions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The answer value to show the sub questions.",
        SerializedName = @"showSubQuestionsValue",
        PossibleTypes = new [] { typeof(string) })]
        string ShowSubQuestionsValue { get;  }
        /// <summary>Superior question id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Superior question id.",
        SerializedName = @"superiorQuestionId",
        PossibleTypes = new [] { typeof(string) })]
        string SuperiorQuestionId { get;  }

    }
    /// The definition of a scoping question.
    internal partial interface IScopingQuestionInternal

    {
        /// <summary>Input type of the question answer.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("None", "Text", "Email", "MultilineText", "Url", "Number", "Boolean", "Telephone", "YesNoNa", "Date", "YearPicker", "SingleSelection", "SingleSelectDropdown", "MultiSelectCheckbox", "MultiSelectDropdown", "MultiSelectDropdownCustom", "Group", "Upload")]
        string InputType { get; set; }
        /// <summary>Option id list.</summary>
        System.Collections.Generic.List<string> OptionId { get; set; }
        /// <summary>Question id.</summary>
        string QuestionId { get; set; }
        /// <summary>The rule of the question.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Required", "CharLength", "Url", "Urls", "Domains", "USPrivacyShield", "PublicSOX", "CreditCardPCI", "AzureApplication", "ValidGuid", "PublisherVerification", "DynamicDropdown", "PreventNonEnglishChar", "ValidEmail")]
        System.Collections.Generic.List<string> Rule { get; set; }
        /// <summary>The answer value to show the sub questions.</summary>
        string ShowSubQuestionsValue { get; set; }
        /// <summary>Superior question id.</summary>
        string SuperiorQuestionId { get; set; }

    }
}