// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Solution replacement maps.</summary>
    public partial class ReplacementMapsSelfHelp :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMapsSelfHelp,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IReplacementMapsSelfHelpInternal
    {

        /// <summary>Backing field for <see cref="Video" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo> _video;

        /// <summary>
        /// Video solutions, which have the power to engage the customer by stimulating their senses
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo> Video { get => this._video; set => this._video = value; }

        /// <summary>Backing field for <see cref="VideoGroup" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup> _videoGroup;

        /// <summary>Group of Videos</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup> VideoGroup { get => this._videoGroup; set => this._videoGroup = value; }

        /// <summary>Backing field for <see cref="WebResult" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult> _webResult;

        /// <summary>Solution AzureKB results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult> WebResult { get => this._webResult; set => this._webResult = value; }

        /// <summary>Creates an new <see cref="ReplacementMapsSelfHelp" /> instance.</summary>
        public ReplacementMapsSelfHelp()
        {

        }
    }
    /// Solution replacement maps.
    public partial interface IReplacementMapsSelfHelp :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Video solutions, which have the power to engage the customer by stimulating their senses
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Video solutions, which have the power to engage the customer by stimulating their senses",
        SerializedName = @"videos",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo> Video { get; set; }
        /// <summary>Group of Videos</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Group of Videos",
        SerializedName = @"videoGroups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup> VideoGroup { get; set; }
        /// <summary>Solution AzureKB results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Solution AzureKB results",
        SerializedName = @"webResults",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult> WebResult { get; set; }

    }
    /// Solution replacement maps.
    internal partial interface IReplacementMapsSelfHelpInternal

    {
        /// <summary>
        /// Video solutions, which have the power to engage the customer by stimulating their senses
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo> Video { get; set; }
        /// <summary>Group of Videos</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup> VideoGroup { get; set; }
        /// <summary>Solution AzureKB results</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IWebResult> WebResult { get; set; }

    }
}