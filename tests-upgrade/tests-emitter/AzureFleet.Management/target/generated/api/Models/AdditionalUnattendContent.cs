// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Specifies additional XML formatted information that can be included in the
    /// Unattend.xml file, which is used by Windows Setup. Contents are defined by
    /// setting name, component name, and the pass in which the content is applied.
    /// </summary>
    public partial class AdditionalUnattendContent :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContentInternal
    {

        /// <summary>Backing field for <see cref="ComponentName" /> property.</summary>
        private string _componentName;

        /// <summary>
        /// The component name. Currently, the only allowable value is
        /// Microsoft-Windows-Shell-Setup.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string ComponentName { get => this._componentName; set => this._componentName = value; }

        /// <summary>Backing field for <see cref="Content" /> property.</summary>
        private System.Security.SecureString _content;

        /// <summary>
        /// Specifies the XML formatted content that is added to the unattend.xml file for
        /// the specified path and component. The XML must be less than 4KB and must
        /// include the root element for the setting or feature that is being inserted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Security.SecureString Content { get => this._content; set => this._content = value; }

        /// <summary>Backing field for <see cref="PassName" /> property.</summary>
        private string _passName;

        /// <summary>The pass name. Currently, the only allowable value is OobeSystem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string PassName { get => this._passName; set => this._passName = value; }

        /// <summary>Backing field for <see cref="SettingName" /> property.</summary>
        private string _settingName;

        /// <summary>
        /// Specifies the name of the setting to which the content applies. Possible values
        /// are: FirstLogonCommands and AutoLogon.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string SettingName { get => this._settingName; set => this._settingName = value; }

        /// <summary>Creates an new <see cref="AdditionalUnattendContent" /> instance.</summary>
        public AdditionalUnattendContent()
        {

        }
    }
    /// Specifies additional XML formatted information that can be included in the
    /// Unattend.xml file, which is used by Windows Setup. Contents are defined by
    /// setting name, component name, and the pass in which the content is applied.
    public partial interface IAdditionalUnattendContent :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The component name. Currently, the only allowable value is
        /// Microsoft-Windows-Shell-Setup.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The component name. Currently, the only allowable value is
        Microsoft-Windows-Shell-Setup.",
        SerializedName = @"componentName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Microsoft-Windows-Shell-Setup")]
        string ComponentName { get; set; }
        /// <summary>
        /// Specifies the XML formatted content that is added to the unattend.xml file for
        /// the specified path and component. The XML must be less than 4KB and must
        /// include the root element for the setting or feature that is being inserted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = true,
        Update = true,
        Description = @"Specifies the XML formatted content that is added to the unattend.xml file for
        the specified path and component. The XML must be less than 4KB and must
        include the root element for the setting or feature that is being inserted.",
        SerializedName = @"content",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString Content { get; set; }
        /// <summary>The pass name. Currently, the only allowable value is OobeSystem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The pass name. Currently, the only allowable value is OobeSystem.",
        SerializedName = @"passName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("OobeSystem")]
        string PassName { get; set; }
        /// <summary>
        /// Specifies the name of the setting to which the content applies. Possible values
        /// are: FirstLogonCommands and AutoLogon.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the name of the setting to which the content applies. Possible values
        are: FirstLogonCommands and AutoLogon.",
        SerializedName = @"settingName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("AutoLogon", "FirstLogonCommands")]
        string SettingName { get; set; }

    }
    /// Specifies additional XML formatted information that can be included in the
    /// Unattend.xml file, which is used by Windows Setup. Contents are defined by
    /// setting name, component name, and the pass in which the content is applied.
    internal partial interface IAdditionalUnattendContentInternal

    {
        /// <summary>
        /// The component name. Currently, the only allowable value is
        /// Microsoft-Windows-Shell-Setup.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Microsoft-Windows-Shell-Setup")]
        string ComponentName { get; set; }
        /// <summary>
        /// Specifies the XML formatted content that is added to the unattend.xml file for
        /// the specified path and component. The XML must be less than 4KB and must
        /// include the root element for the setting or feature that is being inserted.
        /// </summary>
        System.Security.SecureString Content { get; set; }
        /// <summary>The pass name. Currently, the only allowable value is OobeSystem.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("OobeSystem")]
        string PassName { get; set; }
        /// <summary>
        /// Specifies the name of the setting to which the content applies. Possible values
        /// are: FirstLogonCommands and AutoLogon.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("AutoLogon", "FirstLogonCommands")]
        string SettingName { get; set; }

    }
}