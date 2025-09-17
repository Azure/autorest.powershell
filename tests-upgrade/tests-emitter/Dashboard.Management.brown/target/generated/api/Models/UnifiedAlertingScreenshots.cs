// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>Grafana Unified Alerting Screenshots settings</summary>
    public partial class UnifiedAlertingScreenshots :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshots,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshotsInternal
    {

        /// <summary>Backing field for <see cref="CaptureEnabled" /> property.</summary>
        private bool? _captureEnabled;

        /// <summary>
        /// Set to false to disable capture screenshot in Unified Alert due to performance issue.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public bool? CaptureEnabled { get => this._captureEnabled; set => this._captureEnabled = value; }

        /// <summary>Creates an new <see cref="UnifiedAlertingScreenshots" /> instance.</summary>
        public UnifiedAlertingScreenshots()
        {

        }
    }
    /// Grafana Unified Alerting Screenshots settings
    public partial interface IUnifiedAlertingScreenshots :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Set to false to disable capture screenshot in Unified Alert due to performance issue.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set to false to disable capture screenshot in Unified Alert due to performance issue.",
        SerializedName = @"captureEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CaptureEnabled { get; set; }

    }
    /// Grafana Unified Alerting Screenshots settings
    internal partial interface IUnifiedAlertingScreenshotsInternal

    {
        /// <summary>
        /// Set to false to disable capture screenshot in Unified Alert due to performance issue.
        /// </summary>
        bool? CaptureEnabled { get; set; }

    }
}