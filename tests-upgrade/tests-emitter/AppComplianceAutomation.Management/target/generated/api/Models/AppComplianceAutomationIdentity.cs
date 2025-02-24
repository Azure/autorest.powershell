// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    public partial class AppComplianceAutomationIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IAppComplianceAutomationIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IAppComplianceAutomationIdentityInternal
    {

        /// <summary>Backing field for <see cref="EvidenceName" /> property.</summary>
        private string _evidenceName;

        /// <summary>The evidence name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string EvidenceName { get => this._evidenceName; set => this._evidenceName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="ReportName" /> property.</summary>
        private string _reportName;

        /// <summary>Report Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ReportName { get => this._reportName; set => this._reportName = value; }

        /// <summary>Backing field for <see cref="ScopingConfigurationName" /> property.</summary>
        private string _scopingConfigurationName;

        /// <summary>The scoping configuration of the specific report.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ScopingConfigurationName { get => this._scopingConfigurationName; set => this._scopingConfigurationName = value; }

        /// <summary>Backing field for <see cref="SnapshotName" /> property.</summary>
        private string _snapshotName;

        /// <summary>Snapshot Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string SnapshotName { get => this._snapshotName; set => this._snapshotName = value; }

        /// <summary>Backing field for <see cref="WebhookName" /> property.</summary>
        private string _webhookName;

        /// <summary>Webhook Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string WebhookName { get => this._webhookName; set => this._webhookName = value; }

        /// <summary>Creates an new <see cref="AppComplianceAutomationIdentity" /> instance.</summary>
        public AppComplianceAutomationIdentity()
        {

        }
    }
    public partial interface IAppComplianceAutomationIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The evidence name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The evidence name.",
        SerializedName = @"evidenceName",
        PossibleTypes = new [] { typeof(string) })]
        string EvidenceName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Report Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Report Name.",
        SerializedName = @"reportName",
        PossibleTypes = new [] { typeof(string) })]
        string ReportName { get; set; }
        /// <summary>The scoping configuration of the specific report.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The scoping configuration of the specific report.",
        SerializedName = @"scopingConfigurationName",
        PossibleTypes = new [] { typeof(string) })]
        string ScopingConfigurationName { get; set; }
        /// <summary>Snapshot Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Snapshot Name.",
        SerializedName = @"snapshotName",
        PossibleTypes = new [] { typeof(string) })]
        string SnapshotName { get; set; }
        /// <summary>Webhook Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Webhook Name.",
        SerializedName = @"webhookName",
        PossibleTypes = new [] { typeof(string) })]
        string WebhookName { get; set; }

    }
    internal partial interface IAppComplianceAutomationIdentityInternal

    {
        /// <summary>The evidence name.</summary>
        string EvidenceName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>Report Name.</summary>
        string ReportName { get; set; }
        /// <summary>The scoping configuration of the specific report.</summary>
        string ScopingConfigurationName { get; set; }
        /// <summary>Snapshot Name.</summary>
        string SnapshotName { get; set; }
        /// <summary>Webhook Name.</summary>
        string WebhookName { get; set; }

    }
}