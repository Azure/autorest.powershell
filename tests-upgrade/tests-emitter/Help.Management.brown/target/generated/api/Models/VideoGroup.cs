// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Video group detail</summary>
    public partial class VideoGroup :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroup,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroupInternal
    {

        /// <summary>Backing field for <see cref="ReplacementKey" /> property.</summary>
        private string _replacementKey;

        /// <summary>Place holder used in HTML Content replace control with the insight content</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string ReplacementKey { get => this._replacementKey; set => this._replacementKey = value; }

        /// <summary>Backing field for <see cref="Video" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroupVideo> _video;

        /// <summary>List of videos will be shown to customers</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroupVideo> Video { get => this._video; set => this._video = value; }

        /// <summary>Creates an new <see cref="VideoGroup" /> instance.</summary>
        public VideoGroup()
        {

        }
    }
    /// Video group detail
    public partial interface IVideoGroup :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable
    {
        /// <summary>Place holder used in HTML Content replace control with the insight content</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Place holder used in HTML Content replace control with the insight content",
        SerializedName = @"replacementKey",
        PossibleTypes = new [] { typeof(string) })]
        string ReplacementKey { get; set; }
        /// <summary>List of videos will be shown to customers</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of videos will be shown to customers",
        SerializedName = @"videos",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroupVideo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroupVideo> Video { get; set; }

    }
    /// Video group detail
    internal partial interface IVideoGroupInternal

    {
        /// <summary>Place holder used in HTML Content replace control with the insight content</summary>
        string ReplacementKey { get; set; }
        /// <summary>List of videos will be shown to customers</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroupVideo> Video { get; set; }

    }
}