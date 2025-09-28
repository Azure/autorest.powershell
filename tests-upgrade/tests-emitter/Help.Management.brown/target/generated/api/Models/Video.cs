// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Video detail</summary>
    public partial class Video :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideo,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroupVideo" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroupVideo __videoGroupVideo = new Microsoft.Azure.PowerShell.Cmdlets.Help.Models.VideoGroupVideo();

        /// <summary>Backing field for <see cref="ReplacementKey" /> property.</summary>
        private string _replacementKey;

        /// <summary>Place holder used in HTML Content replace control with the insight content</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string ReplacementKey { get => this._replacementKey; set => this._replacementKey = value; }

        /// <summary>Link to the video</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string Src { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroupVideoInternal)__videoGroupVideo).Src; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroupVideoInternal)__videoGroupVideo).Src = value ?? null; }

        /// <summary>Title of the video</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Inherited)]
        public string Title { get => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroupVideoInternal)__videoGroupVideo).Title; set => ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroupVideoInternal)__videoGroupVideo).Title = value ?? null; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__videoGroupVideo), __videoGroupVideo);
            await eventListener.AssertObjectIsValid(nameof(__videoGroupVideo), __videoGroupVideo);
        }

        /// <summary>Creates an new <see cref="Video" /> instance.</summary>
        public Video()
        {

        }
    }
    /// Video detail
    public partial interface IVideo :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroupVideo
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

    }
    /// Video detail
    internal partial interface IVideoInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IVideoGroupVideoInternal
    {
        /// <summary>Place holder used in HTML Content replace control with the insight content</summary>
        string ReplacementKey { get; set; }

    }
}